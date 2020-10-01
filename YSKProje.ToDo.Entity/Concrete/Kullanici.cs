using System.Collections.Generic;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.Entities.Concrete
{
    public class Kullanici: ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }


        //Kullanıcı birden çok çalışma yaptığından dolayı
        //list olarak tanımlıyoruz 
        public List<Calisma> Calismalar { get; set; }
    }
}
