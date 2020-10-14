using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.Web.Extensions
{
    //extension kullanmak için classı static yapmalıyız
    public static class SessionExtension
    {
        //methoda static olması lazım ve bir obje atamamız lazım
        public static void SetObject(this ISession session, string key, object deger)
        {
            //serialize json tipine çeviriyoruz
            string gelenData = JsonConvert.SerializeObject(deger);
            session.SetString(key, gelenData);
        }
        public static T GetObject<T>(this ISession session, string key) where T:class, new()
        {
            string gelenData = session.GetString(key);
            if(gelenData!=null)
            {
                return JsonConvert.DeserializeObject<T>(gelenData);
            }
            return null;
        }
    }
}
