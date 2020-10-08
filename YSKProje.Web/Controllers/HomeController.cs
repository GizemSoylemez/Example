using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSKProje.Web.Models;

namespace YSKProje.Web.Controllers
{
    //Route ister burada ister startupun içinde kullanabiliriz
    //[Route("kisiler/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ACtiondan view 4 yöntemle veri taşıyabiliriz
            //1-viewbag ve 3- aynı işi yapıyor 
            //2-tempdata: bir veriyi başka bir actiona taşımaya yarıyor
            //3-viewdata
            //4-model
            ViewBag.Isim = "Gizem";
            TempData["Isim"] = "Gizem";
            ViewData["Isim"] = "Cennet";
            return View();
        }

        [Route("kisiler/[action]")]
        public IActionResult Sonuc()
        {
            return View();
        }
    }
}