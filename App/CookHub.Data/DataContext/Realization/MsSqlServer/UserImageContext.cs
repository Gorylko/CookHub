using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    class UserImageContext : IUserImageContext, IMapper<Image, DataRow, DataTable>
    {
        public Image MapEntity(DataRow row)
        {
            return null;
        }

        public IReadOnlyCollection<Image> MapEntities(DataTable table)
        {
            return table.AsEnumerable().Select(image => {
                return new Image
                {
                    Id = image.Field<int>("Id"),
                    Path = image.Field<string>("Path")
                };
            }).ToList();
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
