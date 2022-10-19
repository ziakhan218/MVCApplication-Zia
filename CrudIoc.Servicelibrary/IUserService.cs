
using CrudIoc.Corelibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudIoc.Servicelibrary
{
    public interface IUserService
    {
        IQueryable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
