using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.DataAccess.Repository
{
    public interface IRepository : IDisposable
    {
        IQueryable<T> Get<T>() where T : class;
        IQueryable<T> GetIncluding<T>(params Expression<Func<T, object>>[] include) where T : class;
        int Insert<T>(object entity) where T : class;
        int Update<T>(object entity) where T : class;
        int Delete<T>(object entity) where T : class;
    }
}
