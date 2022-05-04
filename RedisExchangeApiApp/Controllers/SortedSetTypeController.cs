using Microsoft.AspNetCore.Mvc;
using RedisExchangeApiApp.Services;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisExchangeApiApp.Controllers
{
    public class SortedSetTypeController : Controller
    {
        private readonly RedisService _redisService;

        private IDatabase db;

        private string listkey = "sortedsetnames";

        public SortedSetTypeController(RedisService redisService)
        {
            _redisService = redisService;
            db = redisService.GetDB(3); // 3 yaziriqki 3 cu databse istifade ele
        }

        public IActionResult Index()
        {
            List<string> nameList = new List<string>();

            if (db.KeyExists(listkey))
            {
                db.SortedSetScan(listkey).ToList().ForEach(x=> 
                {
                    nameList.Add(x.ToString());
                });
            }
            return View(nameList);
        }

        [HttpPost]
        public IActionResult Add(string name,int score)//score doubleda ola biler
        {
            db.SortedSetAdd(listkey,name,score);//score hansi yerde olsun deye veririk item unique olur ama score yox
            db.KeyExpire(listkey,DateTime.Now.AddMinutes(5));

            return RedirectToAction("Index");
        }

        public IActionResult DeleteItem(string name = "azik")
        {
            var result = db.SortedSetRemove(listkey,name);
            
            return RedirectToAction("Index");
        }
    }
}
