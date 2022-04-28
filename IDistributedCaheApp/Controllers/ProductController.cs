using IDistributedCaheApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IDistributedCaheApp.Controllers
{
    public class ProductController : Controller
    {

        private IDistributedCache _distributedCache;

        public ProductController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        public IActionResult Index()
        {
            DistributedCacheEntryOptions options = new DistributedCacheEntryOptions();
            options.AbsoluteExpiration = DateTime.Now.AddMinutes(1);

            Product product = new Product {Id = 1,Name = "Phone", Price = 1000 };

            string jsonobject = JsonConvert.SerializeObject(product);

            _distributedCache.SetString("name", "Qurban",options);
            _distributedCache.SetString("product", jsonobject,options);

            return View();
        }
        
        public IActionResult Show()
        {
            var product = _distributedCache.GetString("product");
            Product p = JsonConvert.DeserializeObject<Product>(product);

            ViewBag.p = p;
            ViewBag.name = _distributedCache.GetString("name");
            return View();
        }

        public IActionResult Remove()
        {
            _distributedCache.Remove("name");
            return View();
        }

        public IActionResult ImageCache()
        {
            DistributedCacheEntryOptions options = new DistributedCacheEntryOptions();
            options.AbsoluteExpiration = DateTime.Now.AddMinutes(1);

            string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/download.jpg");
            Byte[] imageByte = System.IO.File.ReadAllBytes(path);//butun pdf image her weyi byte cevirib cachelemek olar

            _distributedCache.Set("wekil",imageByte,options);
            return View();
        }

        public IActionResult ImageUrl()
        {
            Byte[] wekilByte = _distributedCache.Get("wekil");

            return File(wekilByte,"image/jpg");
        }
    }
}
