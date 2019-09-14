using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.DataContext.Interfaces
{
    public interface IRecipeContext : IDataContext<Recipe>
    {
        IReadOnlyCollection<Recipe> GetAllByUserId(int userId);
    }
}
