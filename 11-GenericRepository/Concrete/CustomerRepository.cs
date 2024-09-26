using _11_GenericRepository.Abstract;
using NorthwindEntities.SqlServerEntities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GenericRepository.Concrete
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public bool CheckForCountry(string country)
        {
          return  base.GetBy(p=>p.Country.ToLower()==country.ToLower())==null?false:true;
        }

        public override int Insert(Customer entity)
        {
            // Eger Israil'e musteri tanimlamalasi yapiliyorsa yapma.
            // Onceden ayni ulkeden musterisi varsa da yapma

            var culture = CultureInfo.CreateSpecificCulture("en-USA");
            if (entity.Country.ToLower(culture) != "Israil".ToLower() && !CheckForCountry(entity.Country))
            {
                return base.Insert(entity);
            }

            
            return 0;
        }
    }
}
