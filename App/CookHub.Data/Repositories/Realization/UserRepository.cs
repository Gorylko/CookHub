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
    public class UserRepository : IUserRepository
    {
        private IUserContext _context;
        public UserRepository(IUserContext context)
        {
            this._context = context ?? throw new NullReferenceException(nameof(context));
        }
        public void Delete(int id)
        {
            _context.Delete(id);
        }

        public IReadOnlyCollection<User> GetAll()
        {
            return _context.GetAll();
        }

        public User GetById(int id)
        {
            return _context.GetById(id);
        }

        public void Save(User obj)
        {
            _context.Save(obj);
        }
    }
}
