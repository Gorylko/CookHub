using CookHub.Shared.Interfaces.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Entities
{
    public class UserImage : IUserImage
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Path { get; set; }
    }
}
