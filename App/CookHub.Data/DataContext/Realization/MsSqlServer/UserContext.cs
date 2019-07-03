using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using CookHub.Shared.Interfaces;
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

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    class UserContext
    {

        private IUser MapUser(SqlDataReader reader)
        {
            IUser user = new User
            {
                Id = (int)reader["Id"],
                Login = (string)reader["Login"],
                Password = (string)reader["Password"],
                PhoneNumber = (string)reader["PhoneNumber"],
                Role = EnumParser.Parse<RoleType>((string)reader["Name"])
            };

            return user;
        }

        public IReadOnlyCollection<IUser> GetAll()
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var list = new List<IUser>();
                var command = new SqlCommand("SELECT [dbo].[User] JOIN [dbo].[Role] on [User.RoleId] = [dbo].[Role.Id]", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(MapUser(reader));
                }

                return list;
            }
        }

        public IUser GetById(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand("SELECT [dbo].[User] WHERE [dbo].[User.Id] = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                reader.Read();
                return MapUser(reader);
            }
        }

        public void Save(IUser user)
        {
            using(var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand("INSERT INTO [dbo].[User]([Id], [Login], [Email], [PhoneNumber], [RoleId]) VALUES (@id, @login, @email, @phoneNumber, @roleId)", connection);
                //command.Parameters could be one variable: command.Parameters = sqlParameter
                //if id is long it would be better
                command.Parameters.AddWithValue("id", user.Id);
                command.Parameters.AddWithValue("login", user.Id);
                command.Parameters.AddWithValue("email", user.Email);
                command.Parameters.AddWithValue("phoneNumber", user.PhoneNumber);
                command.Parameters.AddWithValue("roleId", (int)user.Role);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using(var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand("DELETE [User] WHERE [Id] = @id");
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

    }
}
