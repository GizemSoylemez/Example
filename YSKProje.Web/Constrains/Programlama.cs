using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.Web.Constrains
{
    public class Programlama : IRouteConstraint
    {
        //Proğramlama dilleriyle ilgili bir kategori işlemi olacak
        //ve sadece belirli dillerin yazılmasını istiyorum bunların dışında
        // bir dil yazılırsa ilgili routinge gitmesini istemiyorum
        public List<string> programaDilleri = new List<string> { "csharp", "java", "php" };
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return programaDilleri.Contains(values[routeKey].ToString().ToLower());
        }
    }
}
