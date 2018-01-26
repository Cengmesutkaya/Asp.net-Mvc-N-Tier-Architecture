using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace BussinessLayer.Abstract
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
