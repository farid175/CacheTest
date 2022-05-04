using Microsoft.AspNetCore.Mvc;
using RedisExchangeApiApp.Services;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisExchangeApiApp.Controllers
{
    public class HashTypeController : Controller
    {
        private readonly RedisService _redisService;

        private IDatabase db;

        private string listkey = "dictionary";

        public HashTypeController(RedisService redisService)
        {
            _redisService = redisService;
            db = redisService.GetDB(5); // 1 yaziriqki 1 ci databse istifade ele
        }

        public IActionResult Index()
        {
            Dictionary<string, string> keyValues = new Dictionary<string, string>();

            if (db.KeyExists(listkey))
            {
                db.HashGetAll(listkey).ToList().ForEach(x=> 
                {
                    keyValues.Add(x.Name,x.Value);
                });
            }
            return View(keyValues);
        }

        [HttpPost]
        public IActionResult Add(string name,string value)
        {
            db.HashSet(listkey,name,value);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteItem(string key)
        {
            db.HashDelete(listkey,key) ;
            return RedirectToAction("Index");
        }
    }
}
