using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentApiKullanimi.Models
{
    public class Urun
    {
        public int UrunID { get; set; }

        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        
        public double? Fiyat { get; set; } = 0;
        
        public double? Adet { get; set; } = 0;

        public int KategoriId { get; set; }
        ////Navigation property . Database'e yansimaz.
        //// EfCore icerisinde kullanilir.
        public Kategori Kategori { get; set; }
    }
}
