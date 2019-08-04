using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.DataContext.Interfaces
{
    public interface IDataContext<T> //базовый интерфейс, от него уже могут идти наследники
    {
        IReadOnlyCollection<T> GetAll();

        T GetById(int id);

        void Delete(int id);

        void Save(T obj);
    }
}
