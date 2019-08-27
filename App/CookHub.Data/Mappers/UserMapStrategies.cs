using CookHub.Shared.Entities;
using CookHub.Shared.Entities.Enums;
using System.Data;

namespace CookHub.Data.Mappers
{
    class UserMapStrategies
    {
        internal static User MapEntity(DataRow userRow)
        {
            return new User
            {
                Id = userRow.Field<int>("Id"),
                Login = userRow.Field<string>("Login"),
                Email = userRow.Field<string>("Email"),
                PhoneNumber = userRow.Field<string>("PhoneNumber"),
                Role = (RoleType)userRow.Field<int>("RoleId"),
            };
        }

    }
}
