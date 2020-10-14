using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.Web.Models
{
    public class KullaniciKayitModelView
    {
        [Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
