using Solutions.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.DataAccess.Repository
{
    public class BaseRepository : IRepository
    {
        private SolutionsEntities _context;

        public BaseRepository()
        {
            _context = new SolutionsEntities();
        }

        public IQueryable<T> Get<T>() where T : class
        {
            return _context.Set<T>();
        }

        public IQueryable<T> GetIncluding<T>(params Expression<Func<T, object>>[] include) where T : class
        {
            IQueryable<T> retVal = _context.Set<T>();

            foreach (var item in include)
            {
                retVal = retVal.Include(item);
            }

            return retVal;
        }

        public int Insert<T>(object entity) where T : class
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges();
        }

        public int Update<T>(object entity) where T : class
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges();
        }

        public int Delete<T>(object entity) where T : class
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null) _context.Dispose();
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}
