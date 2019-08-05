using System.Collections.Generic;
using System.Data;

namespace CookHub.Data.DataContext.Interfaces
{
    internal interface IMapper<T, TData, TComplexData>
    {
        T MapEntity(TData data);

        IReadOnlyCollection<T> MapEntities(TComplexData data);
    }
}
