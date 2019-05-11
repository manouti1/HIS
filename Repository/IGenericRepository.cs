using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IGenericRepository<T> where T : BaseObject
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
