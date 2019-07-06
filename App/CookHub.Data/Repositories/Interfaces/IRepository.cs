using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IReadOnlyCollection<T> GetAll();

        T GetById(int id);

        void Delete(int id);

        void Save(T obj);
    }
}
