using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YSKProje.Web.Models;

namespace YSKProje.Web.Controllers
{
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
            return View(new List<MusteriModelView>()
            {
                new MusteriModelView(){Ad="Gizem1"},
                new MusteriModelView(){Ad="Gizem2"},
                new MusteriModelView(){Ad="Gizem3"},
                new MusteriModelView(){Ad="Gizem4"},
                new MusteriModelView(){Ad="Gizem5"}
            }
                );
        }
        public IActionResult Sonuc()
        {
            return View();
        }
    }
}