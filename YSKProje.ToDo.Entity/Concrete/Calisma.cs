using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.Entities.Concrete
{
    public class Calisma: ITablo
    {
       
        public int Id { get; set; }
        public string Ad { get; set; }
        public bool Durum { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }


        //Çalışamanın bir kullanıcısı olacağından dolayı
        //buraya kullanıcı classından onu tanımlıyoruz
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
    }
}
