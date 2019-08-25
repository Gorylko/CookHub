using CookHub.Business.Services.Interfaces;
using CookHub.Data.DataContext.Realization.MsSqlServer;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Data.Repositories.Realization;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Business.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            this._userRepository = repository;
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public IReadOnlyCollection<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Save(User obj)
        {
            _userRepository.Save(obj);
        }
    }
}
