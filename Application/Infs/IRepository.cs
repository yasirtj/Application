using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Infs
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(int Id ,T entity);
        void Delete(int Id);
        void Save();
    }
}
