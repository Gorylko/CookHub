using System.Collections.Generic;
using System.Data;

namespace CookHub.Data.DataContext.Interfaces
{
    internal interface IMapper<T>
    {
        T MapEntity(DataRow row);

        IReadOnlyCollection<T> MapEntities(DataTable table);
    }
}
