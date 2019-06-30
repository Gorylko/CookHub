using CookHub.Shared.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }

        string Login { get; set; }

        string Email { get; set; }

        string PhoneNumber { get; set; }

        string Password { get; set; }

        RoleType Role { get; set; }

    }
}
