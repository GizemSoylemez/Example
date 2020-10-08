using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.Web.Middleware
{
    public static class CustomFileExtension
    {
        //Extension metot yapabilmemiz için ilgili metodun statik olması lazım 
        public static void UseCustomStaticFile(this IApplicationBuilder app)
        {
            app.UseStaticFiles(new StaticFileOptions()
            {
                //content diye istek geldiğinde bana burayı aç diyorum 
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = "/content"
            });
        }
    }
}
