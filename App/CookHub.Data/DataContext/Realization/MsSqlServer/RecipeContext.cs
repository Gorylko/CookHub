using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.DbContext.Interfaces;
using CookHub.Data.DbContext.Realization;
using CookHub.Shared.Entities;
using CookHub.Shared.Entities.Enums;
using CookHub.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeContext : IRecipeContext
    {
        private IMapper<User> _userMapper = new UserContext();
        private IMapper<Ingredient> _ingredientMapper;
        private IExecutor _executor;
        private RecipeImageContext _recipeImageContext = new RecipeImageContext();

        public RecipeContext()
        {
            _executor = new ProcedureExecutor();
            _ingredientMapper = new IngredientContext();
        }

        internal Recipe MapRecipe(DataRow recipeRow, DataTable ingredientsTable, DataTable imagesTable, DataRow userRow)
        {
            return new Recipe
            {
                Id = recipeRow.Field<int>("Id"),
                Name = recipeRow.Field<string>("Name"),
                Description = recipeRow.Field<string>("Description"),
                Author = _userMapper.MapEntity(userRow),
                Ingredients = _ingredientMapper.MapEntities(ingredientsTable),
                Images = _recipeImageContext.MapEntities(imagesTable)
            };
        }

        public Recipe GetById(int id)
        {
            var dataSet = _executor.ExecuteDataSet("sp_select_recipe_by_id", new Dictionary<string, object> {
                {"recipeId", id}
            });

            DataRow recipeRow = dataSet.Tables[0].Rows[0];
            DataTable ingrTable = dataSet.Tables[1];
            DataTable imagesTable = dataSet.Tables[2];
            DataRow userRow = dataSet.Tables[3].Rows[0];

            return MapRecipe(recipeRow, ingrTable, imagesTable, userRow);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Recipe obj)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
