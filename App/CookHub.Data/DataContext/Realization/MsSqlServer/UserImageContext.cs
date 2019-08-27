using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    class UserImageContext : IUserImageContext
    {
        public Image GetById(int id)
        {
            return null;
        }

        public void Save(Image userImage)
        {

        }

        public void Delete(int id)
        {

        }

        public IReadOnlyCollection<Image> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
