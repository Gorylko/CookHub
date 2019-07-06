using CookHub.Data.DataContext.Realization.MsSqlServer;
using CookHub.Data.Repositories.Realization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Business.Services
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository(new UserContext());
    }
}
