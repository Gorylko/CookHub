using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Interfaces.User
{
    interface IUserImage
    {
        int Id { get; set; }

        string Path { get; set; }
    }
}
