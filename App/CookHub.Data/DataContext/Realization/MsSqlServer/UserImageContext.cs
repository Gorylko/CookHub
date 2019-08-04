using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookHub.Shared.Helpers;
using SqlConst = CookHub.Data.Constants.SqlConstants;
using CookHub.Shared.Constants;
using CookHub.Shared.Entities.Enums;
using System.Data;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    class UserImageContext
    {
        private UserImage MapEntity(SqlDataReader reader)
        {
            UserImage userImage = new UserImage
            {
                Id = (int)reader["Id"],
                UserId = (int)reader["UserId"],
                Path = (string)reader["Path"],        
            };

            return userImage;
        }

        public UserImage GetById(int id)
        {
            return null;
        }

        public void Save(UserImage userImage)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
