using NorthwindEntities.SqlServerEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GenericRepository.Abstract
{
    public interface ICustomerRepository :IRepository<Customer>
    {
        bool CheckForCountry(string country);
    }
}
