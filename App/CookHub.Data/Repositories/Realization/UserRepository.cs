using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.Repositories.Realization
{
    public class UserRepository : IRepository<User>
    {
        private IDataContext<User> _dataContext;
        public UserRepository(IDataContext<User> context)
        {
            this._dataContext = context;
        }
        public void Delete(int id)
        {
            _dataContext.Delete(id);
        }

        public IReadOnlyCollection<User> GetAll()
        {
            return _dataContext.GetAll();
        }

        public User GetById(int id)
        {
            return _dataContext.GetById(id);
        }

        public void Save(User obj)
        {
            _dataContext.Save(obj);
        }
    }
}
