﻿using CookHub.Shared.Entities.Enums;
using CookHub.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Entities
{
    public class User : IUser
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public RoleType Role { get; set; }

    }
}
