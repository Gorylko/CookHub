using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.DataContext.Interfaces
{
    public interface IIngredientContext : IDataContext<Ingredient>
    {
        IReadOnlyCollection<Ingredient> GetAllByRecipeId(int recipeId);
    }
}
