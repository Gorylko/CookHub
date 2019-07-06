using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using SqlConst = CookHub.Data.Constants.SqlConstants;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using CookHub.Shared.Constants;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeContext : IRecipeContext
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
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Decription = (string)reader["Description"],
                Author = _userContext.GetById((int)reader["UserId"]),
                Ingredients = _ingredientContext.GetAllByRecipeId((int)reader["Id"]),
                //Images = _recipeImageContext.GetAllByRecipeId((int)reader["Id"])
            };
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
                while(reader.Read())
                {
                    list.Add(MapRecipe(reader));
                }
                return list;
            }
        }

        public Recipe GetById(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT [Recipe].*, [RecipeImage].[Path] FROM [dbo].[Recipe]" + Typography.NewLine +
                                             "LEFT JOIN[dbo].[RecipeImage] ON[dbo].[Recipe].[Id] = [dbo].[RecipeImage].[RecipeId]" + Typography.NewLine +
                                             "WHERE [Recipe].[Id] = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                reader.Read();
                return MapRecipe(reader);
            }
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
