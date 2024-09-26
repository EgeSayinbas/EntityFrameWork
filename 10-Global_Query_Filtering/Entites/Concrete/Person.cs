using _10_Global_Query_Filtering.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Global_Query_Filtering.Entites.Concrete
{
    public class Person :BaseEntity
    {
        public string Name { get; set; }
        public string SureName { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public ICollection<Menu> Menuler { get; set; } = new HashSet<Menu>();   

    }
}
