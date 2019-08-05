using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    class UserImageContext : IDataContext<Image>, IMapper<Image>
    {
        public Image MapEntity(DataRow row)
        {
            return null;
        }

        public IReadOnlyCollection<Image> MapEntities(DataTable table)
        {
            throw new NotImplementedException();
        }

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
