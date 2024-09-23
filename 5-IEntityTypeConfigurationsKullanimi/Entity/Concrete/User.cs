using _5_IEntityTypeConfigurationsKullanimi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_IEntityTypeConfigurationsKullanimi.Entity.Concrete
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
       
        public string? Email { get; set; }
        public string? Gsm { get; set; }


    }
}
