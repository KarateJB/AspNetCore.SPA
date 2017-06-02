using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetSpa.Infra.Utility;
using AspNetSpa.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace AspNetSpa_Website.Controllers
{
    [Route("[controller]")]
    public class CachedemoController : BaseController
    {
        private IMemoryCache _cache;
        private Dictionary<string, string> _cacheKeys = null;

        public CachedemoController(IMemoryCache memoryCache)
        {
            this._cache = memoryCache;

            this._cacheKeys = new Dictionary<string, string>();
            this._cacheKeys.Add("Datetime1", "Datetime1");
            this._cacheKeys.Add("Datetime2", "Datetime2");
        }

        [ResponseCache(CacheProfileName = "default")]  //Using CacheProfileName
        // [ResponseCache(Duration = 120, Location = ResponseCacheLocation.Client)]//Cache-Control:private
        // [ResponseCache(Location = ResponseCacheLocation.None)]//No cache  
        [Route("[action]/{name}")]
        public IActionResult Index(string name)
        {
            ViewBag.CurrentDatetime = $"Hello, {name}, it's {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} now";
            LogUtility.Logger.Debug($"Create Index response...");
            return View();
        }

        [ResponseCache(Duration = 120)]//Cache-Control:public 
        [Route("[action]")]
        public IActionResult Help()
        {
            LogUtility.Logger.Debug($"Create Help response...");
            return View();
        }

        [Route("[action]")]
        public IActionResult Now([FromQuery]string clear)
        {
            var clearKey = this._cacheKeys.ToList().TakeWhile(x => x.Key.Equals(clear)).FirstOrDefault();
            if (!clearKey.Equals(default(KeyValuePair<string, string>)))
            { this._cache.Remove(clearKey.Value); }


            #region Traditional way
            DateTime cacheDatetime1;
            var key = this._cacheKeys["Datetime1"].ToString();
            if (!this._cache.TryGetValue(key, out cacheDatetime1))
            {
                //Get value
                cacheDatetime1 = DateTime.Now;

                // Set cache options
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // .SetSlidingExpiration(TimeSpan.FromSeconds(5));
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(5));

                // Save data in cache.
                _cache.Set(key, cacheDatetime1, cacheEntryOptions);
            }
            #endregion

            #region Use GetOrCreate method
            var cacheDatetime2 = _cache.GetOrCreate(this._cacheKeys["Datetime2"], entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(5);
                // entry.SlidingExpiration = TimeSpan.FromSeconds(5);
                return DateTime.Now;
            });
            #endregion

            #region Just get 
            var getDatetime = _cache.Get(this._cacheKeys["Datetime2"]);
            #endregion

            ViewBag.CurrentDatetime1 = cacheDatetime1.ToString("yyyy/MM/dd HH:mm:ss");
            ViewBag.CurrentDatetime2 = cacheDatetime2.ToString("yyyy/MM/dd HH:mm:ss");
            return View();
        }

    }
}
