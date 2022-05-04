using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RedisExchangeApiApp.Models;
using RedisExchangeApiApp.Services;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RedisExchangeApiApp.Controllers
{
    public class StringController : Controller
    {

        private readonly RedisService _redisService;
        private readonly IDatabase db;

        public StringController(RedisService redisService)
        {
            _redisService = redisService;
            db = _redisService.GetDB(0);
        }

        public IActionResult Index()
        {
            db.StringSet("name","Farid");
            db.StringSet("users",100);

            Product product = new Product { Id = 1, Name = "Phone", Stock = 100 };
            var stringProduct = JsonConvert.SerializeObject(product);

            db.StringSet("product",stringProduct);

            return View();
        }

        public IActionResult Show()
        {

            //QEYD : eger biz async metodu async await yazmadan metodda isdetmek isdeyrikse o zaman .Result yazib isdede bilerik bize deyer veriri geri
            // diger halda .Wait yazib isdifade ede bilerik .Wait o demekdiki bize bu metodu cagir geri donen deyer maraqli deyil

            var name = db.StringGet("name");
            db.StringIncrement("users",10); //artirir 10 eded valuenu
            db.StringDecrementAsync("users", 1).Wait();// .Result verse idik geri deyer donecekdi  deceremengt azaldir 1
            var users = db.StringGet("users");
            var pr = db.StringGet("product");

            var product = JsonConvert.DeserializeObject<Product>(pr.ToString());
            ViewBag.name = name;
            ViewBag.users = users;
            ViewBag.product = product;

            return View();
        }
    }
}
