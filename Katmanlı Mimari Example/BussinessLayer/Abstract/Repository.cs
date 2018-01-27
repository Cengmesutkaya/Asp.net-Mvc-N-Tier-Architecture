using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BussinessLayer.Abstract
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        private readonly DatabaseContext _dbContext = new DatabaseContext();
        public Repository( )
        {
            _objectSet = _dbContext.Set<T>();
        }
        public List<T> List()
        {
            return _objectSet.ToList();
        }
        public IQueryable<T> List(Expression<Func<T,bool>> where)
        {
            return _objectSet.Where(where);
        }
        public int Save()
        {
            return _dbContext.SaveChanges();
        }
        public int Insert(T obj)
        {
             _objectSet.Add(obj);
            return Save();
        }
        public int Update(T obj)
        {
            return Save();
        }        
        public int Delete(T obj)
        {
             _objectSet.Remove(obj);
            return Save();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }       
        public T GetById(int Id)
        {
            return _objectSet.Find(Id);
        }
    } 
}
