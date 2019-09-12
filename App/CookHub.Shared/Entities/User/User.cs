using CookHub.Shared.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public IReadOnlyCollection<Image> Images { get; set; }

        public RoleType Role { get; set; }

    }
}
