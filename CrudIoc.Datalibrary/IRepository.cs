
using CrudIoc.Corelibrary;
using System;
using System.Linq;

namespace CrudIoc.Datalibrary
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}
