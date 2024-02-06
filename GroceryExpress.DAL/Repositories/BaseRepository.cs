using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryExpress.DAL.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _table = _context.Set<T>();    

        }

        public virtual T? Find(int id) {
        return _context.Set<T>().Find(id);
        }

        public virtual ICollection<T> FindAll() {
         return _context.Set<T>().ToList();
        }

        public virtual T Add(T entity) {
        
            T? inserted = _context.Set<T>().Add(entity).Entity;    
            _context.SaveChanges();
            return inserted;
        
        }   
        
        public virtual void Delete(T entity) {
        
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        
        
        }   
        
        public virtual void Update(T entity) {
        
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        
        
        }
    }
}
