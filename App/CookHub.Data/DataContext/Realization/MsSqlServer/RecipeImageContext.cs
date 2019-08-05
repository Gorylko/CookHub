using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeImageContext : IDataContext<RecipeImage>, IMapper<RecipeImage>
    {
        public IReadOnlyCollection<RecipeImage> MapEntities(DataTable imagesTable)
        {
            return imagesTable.AsEnumerable().Select(row =>
            {
                return new RecipeImage
                {
                    Id = row.Field<int>("Id"),
                    Path = row.Field<string>("Path")
                };
            }).ToList();
        }

        public RecipeImage MapEntity(DataRow row)
        {
            return null;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<RecipeImage> GetAll()
        {
            throw new NotImplementedException();
        }

        public RecipeImage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(RecipeImage obj)
        {
            throw new NotImplementedException();
        }
    }
}
