using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
    }
}
