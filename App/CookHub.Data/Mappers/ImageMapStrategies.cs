using CookHub.Shared.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CookHub.Data.Helpers;

namespace CookHub.Data.Mappers
{
    internal class ImageMapStrategies
    {
        internal static IReadOnlyCollection<Image> MapImages(DataTable imagesTable)
        {
            return imagesTable.AsEnumerable().Select(row =>
            {
                return new Image
                {
                    Id = row.Field<int>("Id"),
                    Data = ImageHelper.GetImageData(row.Field<string>("Path"))
                };
            }).ToList();
        }
    }
}