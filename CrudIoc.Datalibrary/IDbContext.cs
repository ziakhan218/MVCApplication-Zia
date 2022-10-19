using CrudIoc.Corelibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace CrudIoc.Datalibrary
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
