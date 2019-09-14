using System;
using System.Collections.Generic;
using System.Text;

namespace CookHub.Business.Services.Interfaces
{
    public interface IService<T>
    {
        IReadOnlyCollection<T> GetAll();

        T GetById(int id);

        void Delete(int id);

        void Save(T obj);
    }
}
