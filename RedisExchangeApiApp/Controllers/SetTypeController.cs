using Microsoft.AspNetCore.Mvc;
using RedisExchangeApiApp.Services;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisExchangeApiApp.Controllers
{
    public class SetTypeController : Controller
    {
        private readonly RedisService _redisService;

        private IDatabase db;

        private string listkey = "setnames";

        public SetTypeController(RedisService redisService)
        {
            _redisService = redisService;
            db = redisService.GetDB(2); // 1 yaziriqki 1 ci databse istifade ele
        }
        public IActionResult Index()
        {
            HashSet<string> nameList = new HashSet<string>();

            if (db.KeyExists(listkey))
            {
                db.SetMembers(listkey).ToList().ForEach(x=> 
                {
                    nameList.Add(x);
                });
            }
            return View(nameList);
        }

        public IActionResult Add(string name)
        {
            db.KeyExpire(listkey,DateTime.Now.AddMinutes(5)); //absolutetime veririk
            db.SetAdd(listkey,name);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteItem(string name)
        {
            await db.SetRemoveAsync(listkey,name);
            return RedirectToAction("Index");
        }
    }
}
