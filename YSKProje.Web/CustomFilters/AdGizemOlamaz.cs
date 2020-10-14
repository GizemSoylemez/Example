using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.Web.Models;

namespace YSKProje.Web.CustomFilters
{
    public class AdGizemOlamaz: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionaryGelen = context.ActionArguments.Where(I => I.Key == "model").FirstOrDefault();
            var model = (KullaniciKayitModelView)dictionaryGelen.Value;

            if(model.Ad.ToLower()=="gizem")
            {
                context.Result = new RedirectResult(@"\Home\Error");
            }
        }
    }
}
