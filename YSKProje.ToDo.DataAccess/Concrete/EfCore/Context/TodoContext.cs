using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DataAccess.Concrete.EfCore.Mapping;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Concrete.EfCore.Contextintegrated
{
    public class TodoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //database bağlanacak
            optionsBuilder.UseSqlServer(@"server=DESKTOP-S1LPS5E\SQLEXPRESS; 
                   database=udemyBlogToDo; integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Kullanici>().HasKey(I => I.Id);
            //böyle yazılabilir ama bu yöntemde kod okunabilirliiği açısından iyi bir yöntem değildir.
            //böyle yazmak yerine mapping adı altında bir klasör oluşturuyoruz oraya yazıyoruz orada yazdıklarımızı
            //burada tanımlıyoruz
            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new CalismaMAp());
        }


        //tablolarımı belirtmem lazım bunun içinde dbset kullanıyorum
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Calisma> Calismalar { get; set; }
    }
}
