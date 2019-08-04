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
        private UserContext _userContext;
        private IngredientContext _ingredientContext;
        private IExecutor _executor;

        public RecipeContext()
        {
            _executor = new ProcedureExecutor();
            this._userContext = new UserContext();
            this._ingredientContext = new IngredientContext();
        }

        private Recipe MapEntity(DataRow recipeRow, DataTable ingredientsTable, DataTable imagesTable, DataRow userRow)
        {
            return new Recipe
            {
                Id = recipeRow.Field<int>("Id"),
                Name = recipeRow.Field<string>("Name"),
                Description = recipeRow.Field<string>("Description"),
                Author = _userContext.MapUser(userRow),
                Ingredients = _ingredientContext.MapIngredients(ingredientsTable),
                Images = _recipeImageContext.MapImages(imagesTable)
            };
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            //var list = new List<Recipe>();
            //using (var connection = new SqlConnection(SqlConst.ConnectionString))
            //{
            //    connection.Open();
            //    var command = new SqlCommand("SELECT [Recipe].*, [RecipeImage].[Path] FROM [dbo].[Recipe]" + Typography.NewLine +
            //                                 "LEFT JOIN[dbo].[RecipeImage] ON[dbo].[Recipe].[Id] = [dbo].[RecipeImage].[RecipeId]", connection);
            //    var reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        list.Add(MapRecipe(reader));
            //    }
            //    return list;
            //}
            //var list = new List<Recipe>();
            //var dataSet = _executor.ExecuteDataSet("");
            //return list;
            throw new NotImplementedException();
        }

        public Recipe GetById(int id)
        {
            var dataSet = _executor.ExecuteDataSet("sp_select_recipe_by_id", new Dictionary<string, object> {
                {"recipeId", id}
            });

            DataRow recipeRow     = dataSet.Tables[0].Rows[0];
            DataTable ingrTable   = dataSet.Tables[1];
            DataTable imagesTable = dataSet.Tables[2];
            DataRow userRow       = dataSet.Tables[3].Rows[0];

            return MapEntity(recipeRow, ingrTable, imagesTable, userRow);
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
