using _11_GenericRepository.Abstract;
using Microsoft.EntityFrameworkCore;
using NorthwindEntities.SqlServerEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _11_GenericRepository.Concrete
{
    public class Repository<T> : IRepository<T> 
        where T : class
        
    {
        private readonly SqlNorthwinContext _context;
       

        public Repository() 
        {
            _context = new SqlNorthwinContext();


        }
        
        public virtual int Delete(T entity)
        {
           
           _context.Remove(entity);
           return  _context.SaveChanges();
        }

        public virtual int DeleteById(int id)
        {
            
            var entity = _context.Set<T>().Find(id);
            if(entity!=null)
             _context.Remove(entity);

            return _context.SaveChanges();
        }

        public virtual int DeleteById(string id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
                _context.Remove(entity);

            return _context.SaveChanges();
        }
        public virtual T? GetBy(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null ? _context.Set<T>().FirstOrDefault() : _context.Set<T>().FirstOrDefault(predicate);
        }
      
        public virtual List<T>? GetAll(Expression<Func<T, bool>> predicate=null)
        {
            return predicate == null?_context.Set<T>().ToList() : _context.Set<T>().Where(predicate).ToList();             
          
        }

        public virtual T? GetById(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public virtual T? GetById(string id)
        {
            return _context.Set<T>().Find(id);
        }

        public  virtual int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();  
        }

        public virtual int Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges();
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] include)
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
