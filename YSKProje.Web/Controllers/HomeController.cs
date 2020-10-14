using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YSKProje.Web.CustomFilters;
using YSKProje.Web.Extensions;
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

            ////cookie methodlarını burada çağırıyoruz
            //SetCookie();
            //ViewBag.Cookie= GetCookie();

            SetSession();
            ViewBag.Cookie = GetSession();
            return View();
        }

        [Route("kisiler/[action]")]
        public IActionResult Sonuc()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        //dictionary<key,value>
        [AdGizemOlamaz]
        [HttpPost]
                                       //Alttakiler bir arguman aslında dictionary
        public IActionResult KayitOl2(KullaniciKayitModelView model)
        {
            //string ad = HttpContext.Request.Form["Ad"].ToString();
            //ViewBag.Ad = ad;
            if(ModelState.IsValid)
            {

            }
            ModelState.AddModelError(nameof(KullaniciKayitModelView.Ad), "Ad alanı gereklidir");
            ModelState.AddModelError("", "model ile ilgili hata");
            return View("KayitOl",model);
        }

        //Cookie
        public void SetCookie()
        {
            HttpContext.Response.Cookies.Append("kisi", "gizem", new Microsoft.AspNetCore.Http.CookieOptions()
            {
                //Expires --> bu cookie ne kadar yaşayacak
                //Bugünden sonra 20 gün yaşayacak
                Expires = DateTime.Now.AddDays(20),
                //HttpOnly-- ilgili cookienin js alıp alamayağına karar veririz.
                HttpOnly = true,
                //SAmeSite Lax'a kalırsa bir çok internet sayfasından erişilebilir. Sadece strict yaparsak sadece ilgili sayfa erişebilir.
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict,
                Secure=true//http ile çalışacak true yaptığımda cookie mi göremem false yaparsam cookie mi görebilirim

            });
        }

        public string GetCookie()
        {
            return HttpContext.Request.Cookies["kisi"];
        }

        public void SetSession()
        {
            //HttpContext.Session.SetString("kisi", "Gizem");
            HttpContext.Session.SetObject("kisi", new KullaniciKayitModelView()
            {
                Ad = "Cennet Gizem",
                Soyad = "Söylemez"
            });
        }
        public KullaniciKayitModelView GetSession()
        {
            //return HttpContext.Session.GetString("kisi");
            return HttpContext.Session.GetObject<KullaniciKayitModelView>("kisi");
        }

        public IActionResult PageError(int code)
        {
            ViewBag.Code = code;
            if(code==404)
            {
                ViewBag.Message = "SAyfa Bulunamadı";
            }
            return View();
        }
    }
}