using System.Collections.Generic;
using System.Data;

namespace CookHub.Data.DataContext.Interfaces
{
    internal interface IMapper<T, TData, TCollectionData>
    {
        T MapEntity(TData data);

        IReadOnlyCollection<T> MapEntities(TCollectionData data);
    }
}
