using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.DataTypes;
using CookHub.Shared.Entities;
using CookHub.Shared.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class UserContext : IUserContext
    {
        public UserContext()
        {
        }

        public IReadOnlyCollection<User> GetAll()
        {
            throw new Exception();
        }

        public User GetById(int id)
        {
            throw new Exception();
        }

        public void Save(User user)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
