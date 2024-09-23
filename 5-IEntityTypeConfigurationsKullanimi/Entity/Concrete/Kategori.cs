using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IEntityTypeConfigurationsKullanimi.Entity.Concrete
{
    #region DataAnnotations kullanarak property'leri sekillendirmek

    #endregion
    public  class Kategori
    {
        public int Id { get; set; }
      
        public string? KategoriAdi { get; set; }
     
        public string? Aciklama { get; set; } //Aciklama Alanin nullable olacak ve max 1000 karakater alacak
        //Nabigation Peoperty. Database'e yansimaz.
        //Sadece EfCore icerisinde ilgili kayitlari getirmek icin kullanilir.
       public ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();    
    }
}
