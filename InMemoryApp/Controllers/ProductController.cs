using InMemoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InMemoryApp.Controllers
{
    public class ProductController : Controller
    {
        private IMemoryCache _memoryCache;


        public ProductController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            MemoryCacheEntryOptions options = new MemoryCacheEntryOptions();
            options.AbsoluteExpiration = DateTime.Now.AddMinutes(1); // deqiq vaxt
            options.SlidingExpiration = TimeSpan.FromSeconds(10); // burda ise 10 saniye erzinde sorgu gelse yene 10 saniye artyir gelmese silinir
            options.Priority = CacheItemPriority.High; // priorityni high verende yeni en son bunu sil
            options.RegisterPostEvictionCallback((key, value, reason,state) =>
            {
                _memoryCache.Set("callback", $"key:{key} value:{value} reason:{reason}");
            });
            _memoryCache.Set<string>("zaman",DateTime.Now.ToString(),options);
            _memoryCache.Set<Product>("product",new Product {Id = 1,Name = "Notebook",Stock = 100 });
            return View();
        }

        public IActionResult Show()
        {
            _memoryCache.TryGetValue<string>("zaman", out string zaman);
            _memoryCache.TryGetValue<string>("callback", out string callback);
            _memoryCache.TryGetValue<Product>("product", out Product product);
            ViewBag.zaman = _memoryCache.Get<string>("zaman");
            ViewBag.callback = _memoryCache.Get<string>("callback");
            ViewBag.product = _memoryCache.Get<Product>("product");
            
            
            return View();
        }
    }
}
