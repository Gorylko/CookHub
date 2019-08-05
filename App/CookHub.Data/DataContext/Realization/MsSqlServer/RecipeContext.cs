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
        private IMapper<User, DataRow, DataTable> _userMapper;
        private IMapper<Ingredient, DataRow, DataTable> _ingredientMapper;
        private IExecutor _executor;
        private IMapper<Image, DataRow, DataTable> _recipeImageMapper;

        public RecipeContext() //conteiner here
        {
            _userMapper = new UserContext();
            _executor = new ProcedureExecutor();
            _ingredientMapper = new IngredientContext();
            _recipeImageMapper = new RecipeImageContext();
        }

        internal Recipe MapRecipe(DataRow recipeRow, DataTable ingredientsTable, DataTable recipeImagesTable, DataRow userRow, DataTable userImageTable)
        {
            return new Recipe
            {
                Id = recipeRow.Field<int>("Id"),
                Name = recipeRow.Field<string>("Name"),
                Description = recipeRow.Field<string>("Description"),
                Author = _userMapper.MapEntity(),
                Ingredients = _ingredientMapper.MapEntities(ingredientsTable),
                Images = _recipeImageMapper.MapEntities(recipeImagesTable)
            };
        }

        public Recipe GetById(int id)
        {
            var dataSet = _executor.ExecuteDataSet("sp_select_recipe_by_id", new Dictionary<string, object> {
                {"recipeId", id}
            });

            DataRow recipeRow = dataSet.Tables[0].Rows[0];
            DataTable ingrTable = dataSet.Tables[1];
            DataTable recipeImagesTable = dataSet.Tables[2];
            DataRow userRow = dataSet.Tables[3].Rows[0];
            DataTable userImagesTable = dataSet.Tables[4];

            return MapRecipe(recipeRow, ingrTable, recipeImagesTable, userRow, userImagesTable);
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
