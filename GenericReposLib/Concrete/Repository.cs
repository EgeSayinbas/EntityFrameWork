using GenericReposLib.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericReposLib.Concrete
{
    public class Repository<T,TContext> : IRepository<T> 
        where T : class
        where TContext : DbContext,new()
    {
        
       
        readonly TContext _context;
        public Repository() 
        {
            _context = new TContext();


        }
        
        public int Delete(T entity)
        {
           
           _context.Remove(entity);
           return  _context.SaveChanges();
        }

        public int DeleteById(int id)
        {
            
            var entity = _context.Set<T>().Find(id);
            if(entity!=null)
             _context.Remove(entity);

            return _context.SaveChanges();
        }

        public int DeleteById(string id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
                _context.Remove(entity);

            return _context.SaveChanges();
        }
        public T? GetBy(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null ? _context.Set<T>().FirstOrDefault() : _context.Set<T>().FirstOrDefault(predicate);
        }
      
        public List<T>? GetAll(Expression<Func<T, bool>> predicate=null)
        {
            return predicate == null?_context.Set<T>().ToList() : _context.Set<T>().Where(predicate).ToList();             
          
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public T? GetById(string id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();  
        }

        public int Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges();
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query;
            if (predicate != null)
            {
                query =_context.Set<T>().Where(predicate);
            }
            else
            {
                query = _context.Set<T>();
            }

            // return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            //_context.Set<T>().Include(p => p.Supplier);
            var result=  include.Aggregate(query, (abc, xyz) => abc.Include(xyz));
            return result;
        }
    }
}
