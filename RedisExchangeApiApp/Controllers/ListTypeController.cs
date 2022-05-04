using Microsoft.AspNetCore.Mvc;
using RedisExchangeApiApp.Services;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisExchangeApiApp.Controllers
{
    public class ListTypeController : Controller
    {

        private readonly RedisService _redisService;

        private IDatabase db;

        private string listkey = "names";

        public ListTypeController(RedisService redisService)
        {
            _redisService = redisService;
            db = redisService.GetDB(1); // 1 yaziriqki 1 ci databse istifade ele
        }

        public IActionResult Index()
        {
            List<string> nameList = new List<string>();
            if (db.KeyExists(listkey))
            {
                db.ListRange(listkey).ToList().ForEach(x =>
                {
                    nameList.Add(x);
                });
            }
            return View(nameList);
        }

        [HttpPost]
        public IActionResult Add(string name)
        {
            db.ListRightPush(listkey,name);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteItem(string name)
        {
            db.ListRemoveAsync(listkey,name).Wait();
            return RedirectToAction("Index");
        }
    }
}
