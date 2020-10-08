using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using YSKProje.Web.Middleware;
using Microsoft.AspNetCore.Routing.Constraints;
using YSKProje.Web.Constrains;

namespace YSKProje.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Projeme MVC dahil ediyorum
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//Bunu kulland���m�z da www olan� eri�ebilir hale getiririz

            app.UseCustomStaticFile();//Middleware olarak a�t���m class�m� burada tan�ml�yorum
            app.UseRouting();

            //localhost/home
            app.UseEndpoints(endpoints =>
            {
                //Ba�ka routerlar yazaca��m ama bunu yazarken her zaman 
                //kapsay�c� olan� alta al�p di�er routingleri yukar� yazmal�y�z
                endpoints.MapControllerRoute(
                    name: "programlamaRoute",
                    pattern:"programlama/{dil}",
                    defaults: new {controller="Home", action="index"},
                    constraints: new {dil= new Programlama()}
                    );

                endpoints.MapControllerRoute(
                    name:"kisi",
                    pattern:"kisiler",
                    defaults: new {controller="Home", action="Index"}
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}",
                    constraints:new {id=new IntRouteConstraint()}
                    //bunu dememdeki ama� int de�erinde olmas�n� istedi�im i�n 
                    );
            });
        }
    }
}
