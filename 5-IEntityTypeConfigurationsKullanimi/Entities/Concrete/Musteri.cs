using _5_IEntityTypeConfigurationsKullanimi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IEntityTypeConfigurationsKullanimi.Entities.Concrete
{
    public class Musteri :BaseEntity
    {
      
      
        public string MusteriAdi { get; set; }
     
        public string? VergiNo { get; set; }
  
        public string? Email { get; set; }
       
        public string? Gsm { get; set; }
    }
}
