using CookHub.Shared.Entities;
using CookHub.Shared.Entities.Enums;
using CookHub.Shared.Helpers;
using System.Collections.Generic;
using System.Data.SqlClient;
using SqlConst = CookHub.Data.Constants.SqlConstants;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    class UserContext
    {

        private User MapUser(SqlDataReader reader)
        {
            User user = new User
            {
                Id = (int)reader["Id"],
                Login = (string)reader["Login"],
                Password = (string)reader["Password"],
                PhoneNumber = (string)reader["PhoneNumber"],
                Role = EnumParser.Parse<RoleType>((string)reader["Name"])
            };

            return user;
        }

        public IReadOnlyCollection<User> GetAll()
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var list = new List<User>();
                var command = new SqlCommand("SELECT [dbo].[User] JOIN [dbo].[Role] ON [User].[RoleId] = [dbo].[Role].[Id]", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(MapUser(reader));
                }

                return list;
            }
        }

        public User GetById(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand("SELECT [dbo].[User] WHERE [dbo].[User].[Id] = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                reader.Read();
                return MapUser(reader);
            }
        }

        public void Save(User user)
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
