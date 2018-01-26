using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public interface IRepository<T>
    {
        List<T> List();
        IQueryable<T> List(Expression<Func<T, bool>> where);
        int Save();
        int Insert(T obj);
        int Update(T obj);
        int Delete(T obj);
        T Find(Expression<Func<T, bool>> where);
        T GetById(int Id);

    }
}
