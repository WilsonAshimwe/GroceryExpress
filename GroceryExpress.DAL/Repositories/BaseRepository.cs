using Microsoft.EntityFrameworkCore;

namespace GroceryExpress.DAL.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _table;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            _table = _context.Set<T>();

        }

        public async virtual Task<T?> Find(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async virtual Task<List<T>> FindAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async virtual Task<T> Add(T entity)
        {

            T? inserted = (await _context.Set<T>().AddAsync(entity)).Entity;
            await _context.SaveChangesAsync();
            return inserted;

        }

        public async virtual Task Delete(T entity)
        {

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();


        }

        public async virtual Task<T> Update(T entity)
        {

            T? updated = _context.Set<T>().Update(entity).Entity;
            await _context.SaveChangesAsync();
            return updated;



        }
    }
}
