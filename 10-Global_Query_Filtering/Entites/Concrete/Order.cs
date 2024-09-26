using _10_Global_Query_Filtering.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Global_Query_Filtering.Entites.Concrete
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
