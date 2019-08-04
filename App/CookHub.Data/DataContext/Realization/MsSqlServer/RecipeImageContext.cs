using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeImageContext
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
    }
}
