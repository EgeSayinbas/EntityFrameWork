using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CodeFirstMarket.Models
{
    #region DataAnnotations kullanarak property'leri sekillendirmek

    #endregion
    public  class Kategori
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string KategoriAdi { get; set; }
        [MaxLength(1000)]
        public string? Aciklama { get; set; } //Aciklama Alanin nullable olacak ve max 1000 karakater alacak
        //Nabigation Peoperty. Database'e yansimaz.
        //Sadece EfCore icerisinde ilgili kayitlari getirmek icin kullanilir.
       public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();    
    }
}
