using Application.Infs;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Infrastructure.App
{
    public class Repository<T> : IRepository<T> where T :class
    {
        private readonly IStudentDbContext _DbContext;
        public Repository(IStudentDbContext DbContext)
        {
            _DbContext = DbContext;
            
        }
       
        public void Delete(int Id)
        {
            var EntityDelete = _DbContext.Set<T>().Find(Id);
            _DbContext.Set<T>().Remove(EntityDelete);
            Save();
        }

        public T Get(long id)
        {

            return _DbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _DbContext.Set<T>().ToList();
           
        }

        public void Insert(T entity)
        {
            _DbContext.Set<T>().Add(entity);
            Save();
        }

        public void Save()
        {
            _DbContext.Save();
        }

        public void Update(int Id,T entity)
        {
            //DbSet.Attach(entity);
            //var entry = _DbContext.Entry(entity);
            //entry.State = System.Data.EntityState.Modified;

            
            var OldEntity = Get(Id);
            if (OldEntity != null)
            {
                Delete(Id);
                Save();
                Insert(entity);
                Save();
               
            }
            else if (OldEntity == null)
            {
              
            }

        }
    }
}
