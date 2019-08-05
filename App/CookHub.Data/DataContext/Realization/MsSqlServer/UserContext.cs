using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.DataTypes;
using CookHub.Shared.Entities;
using CookHub.Shared.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class UserContext : IDataContext<User>, IMapper<User, UserData, DataTable>
    {
        private IMapper<Image, DataRow, DataTable> _userImageMapper;

        public UserContext()
        {
             _userImageMapper = new UserImageContext();
        }

        public User MapEntity(UserData userData)
        {
            var userRow = userData.UserRow;
            var imagesTable = userData.ImagesTable;
            return new User
            {
                Id = userRow.Field<int>("Id"),
                Login = userRow.Field<string>("Login"),
                Email = userRow.Field<string>("Email"),
                PhoneNumber = userRow.Field<string>("PhoneNumber"),
                Role = (RoleType)userRow.Field<int>("RoleId"),
                Images = _userImageMapper.MapEntities(imagesTable)
            };
        }

        public IReadOnlyCollection<User> MapEntities(DataTable table)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<User> GetAll()
        {
            throw new Exception();
        }

        public User GetById(int id)
        {
            throw new Exception();
        }

        public void Save(User user)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
