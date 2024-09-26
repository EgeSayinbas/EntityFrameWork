using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericReposLib.Abstract
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAllInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] inlude);
        List<T>? GetAll(Expression<Func<T,bool>> predicate=null);  // Sql'deki Where sartinin ifadesi burada Expression<Func<T,bool>> şeklindedir.
        T? GetBy(Expression<Func<T, bool>> predicate =null);
        T? GetById(int id);
        T? GetById(string id);

       

        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        int DeleteById(int id);
        int DeleteById(string id);



    }
}
