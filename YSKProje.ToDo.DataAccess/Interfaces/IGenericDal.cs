using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Interfaces;

namespace YSKProje.ToDo.DataAccess.Interfaces
{
    public interface IGenericDal<Tablo> where Tablo : ITablo
    {
        //Generic olduğu için kafasına göre bir isim veremeyecek ITablodan kalıtsal yollarla geçmiş olmak zorunda
        //class olmak zorunda 
        //newlenebilir olmak zorunda

        void Kaydet(Tablo tablo);
        void Sil(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirId(int id);
        List<Tablo> GetirHepsi();
    }
}
