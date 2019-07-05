using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeContext : IDataContext<Recipe>
    {
        private UserContext _userContext;
        private IngredientContext _ingredientContext;

        public RecipeContext()
        {
            this._userContext = new UserContext();
            this._ingredientContext = new IngredientContext();
        }

        private Recipe MapRecipe(SqlDataReader reader)
        {
            return new Recipe
            {
                Author = _userContext.GetById((int)reader["UserId"]),
                Ingredients = _ingredientContext.GetAllByRecipeId((int)reader["RecipeId"]) //не закончено
            };
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recipe GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Recipe obj)
        {
            throw new NotImplementedException();
        }
    }
}
