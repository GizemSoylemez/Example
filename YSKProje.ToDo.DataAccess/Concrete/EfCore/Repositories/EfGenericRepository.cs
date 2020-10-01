using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YSKProje.ToDo.DataAccess.Concrete.EfCore.Contextintegrated;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.DataAccess.Concrete.EfCore.Repositories
{
    public class EfGenericRepository<Tablo>:IGenericDal<Tablo> where Tablo:class,ITablo,new()
    {
        public List<Tablo> GetirHepsi()
        {
            //içerisine aldığı kaynak tükendiği zaman bu iç kısımdaki kodları garbash gönderiyor
            using var context = new TodoContext();
            return context.Set<Tablo>().ToList();

        }

        public Tablo GetirId(int id)
        {
            using var context = new TodoContext();
            return context.Set<Tablo>().Find(id);
        }

        public void Guncelle(Tablo tablo)
        {
            using var context = new TodoContext();
            //context.Entry(tablo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.Set<Tablo>().Update(tablo);//yukarıdakiyle aynı işlemi yapar
            context.SaveChanges();
        }

        public void Kaydet(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Sil(Tablo tablo)
        {
            using var context = new TodoContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
    }
}
