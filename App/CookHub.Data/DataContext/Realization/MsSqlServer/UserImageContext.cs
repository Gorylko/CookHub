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
    class UserImageContext
    {
        private IUserImage MapUserImage(SqlDataReader reader)
        {
            IUserImage userImage = new UserImage
            {
                Id = (int)reader["Id"],
                UserId = (int)reader["UserId"],
                Path = (string)reader["Path"],        
            };

            return userImage;
        }

        public IUserImage GetById(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand("SELECT [dbo].[UserImage] WHERE [dbo].[UserImage].[Id] = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                reader.Read();
                return MapUserImage(reader);
            }
        }

        public void Save(IUserImage userImage)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand("INSERT INTO [dbo].[UserImage]([Id], [UserId], [Path]) VALUES (@id, @userId, @path)", connection);             
                command.Parameters.AddWithValue("id", userImage.Id);
                command.Parameters.AddWithValue("userId", userImage.UserId);
                command.Parameters.AddWithValue("path", userImage.Path);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand("DELETE [UserImage] WHERE [Id] = @id");
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
