using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeImageContext : IDataContext<Image>, IMapper<Image>
    {
        public IReadOnlyCollection<Image> MapEntities(DataTable imagesTable)
        {
            return imagesTable.AsEnumerable().Select(row =>
            {
                return new Image
                {
                    Id = row.Field<int>("Id"),
                    Path = row.Field<string>("Path")
                };
            }).ToList();
        }

        public Image MapEntity(DataRow row)
        {
            return null;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Image obj)
        {
            throw new NotImplementedException();
        }
    }
}
