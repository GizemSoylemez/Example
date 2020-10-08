using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.Web.Models;

namespace YSKProje.Web.ViewComponents
{
    public class Urunler:ViewComponent
    {
        //ViewComponent kendi kendine çalışan bir asenkronik yapı
        //Invoke metodunu ayağa kaldırmamız gerkiyo
        public IViewComponentResult Invoke()
        {
            return View("Yeni", new List<MusteriModelView>()
            {
                new MusteriModelView(){Ad="Gizem1"},
                new MusteriModelView(){Ad="Gizem2"},
                new MusteriModelView(){Ad="Gizem3"},
                new MusteriModelView(){Ad="Gizem4"},
                new MusteriModelView(){Ad="Gizem5"}
            }
                );
        }
    }
}
