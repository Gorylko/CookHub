using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.Repositories.Interfaces
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        IReadOnlyCollection<Ingredient> GetAllByRecipeId(int recipeId);
    }
}
