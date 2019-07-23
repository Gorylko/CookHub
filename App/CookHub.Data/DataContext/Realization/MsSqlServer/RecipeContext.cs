using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using SqlConst = CookHub.Data.Constants.SqlConstants;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using CookHub.Shared.Constants;
using CookHub.Data.DbContext.Interfaces;
using CookHub.Data.DbContext.Realization;
using System.Data;
using CookHub.Shared.Entities.Enums;
using CookHub.Shared.Helpers;
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

        private Recipe MapRecipe(DataRow recipeData, DataTable ingredientsTable, DataTable imagesTable)
        {
            return new Recipe
            {
                Id = recipeData.Field<int>("Id"),
                Name = recipeData.Field<string>("Name"),
                Decription = recipeData.Field<string>("Decription"),
                Author = _userContext.GetById((int)reader["UserId"]),
                Ingredients = _ingredientContext.GetAllByRecipeId((int)reader["Id"]),
                //Images = _recipeImageContext.GetAllByRecipeId((int)reader["Id"])
            };
        }

        private IReadOnlyCollection<Ingredient> MapIngredients(DataTable table)
        {
            return table.AsEnumerable().Select(ingr => {
                return new Ingredient
                {
                    Id = ingr.Field<int>("Id"),
                    Name = ingr.Field<string>("Name"),
                    Amount = ingr.Field<int>("Amount"),
                    Unit = EnumParser.Parse<UnitType>(ingr.Field<string>("Unit")),
                    NutritionalValue = new NutritionalValue
                    {
                        Protein = ingr.Field<int>("Protein"),
                        Fat = ingr.Field<int>("Fat"),
                        Carbohydrate = ingr.Field<int>("Carbohydrate")
                    }
                };
            }).ToList();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            var list = new List<Recipe>();
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT [Recipe].*, [RecipeImage].[Path] FROM [dbo].[Recipe]" + Typography.NewLine +
                                             "LEFT JOIN[dbo].[RecipeImage] ON[dbo].[Recipe].[Id] = [dbo].[RecipeImage].[RecipeId]", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(MapRecipe(reader));
                }
                return list;
            }
            //var list = new List<Recipe>();
            //var dataSet = _executor.ExecuteDataSet("");
            //return list;
        }

        public Recipe GetById(int id)
        {
            var dataSet = _executor.ExecuteDataSet("sp_select_recipe_by_id", new Dictionary<string, object> {
                {"recipeId", id}
            });
            return MapRecipe(dataSet.Tables[0].Rows[0], dataSet.Tables[1], dataSet.Tables[2]);
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
