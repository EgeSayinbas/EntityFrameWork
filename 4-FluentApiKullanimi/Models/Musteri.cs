using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FluentApiKullanimi.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string? MusteriAdi { get; set; }
        [MaxLength(50)]
        public string? VergiNo { get; set; }
        [MaxLength(50)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? Gsm { get; set; }
    }
}
