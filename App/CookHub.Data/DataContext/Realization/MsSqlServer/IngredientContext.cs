using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookHub.Shared.Helpers;
using SqlConst = CookHub.Data.Constants.SqlConstants;
using CookHub.Shared.Constants;
using CookHub.Shared.Entities.Enums;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class IngredientContext : IIngredientContext
    {
        private Ingredient MapIngredient(SqlDataReader reader)
        {
            return new Ingredient //переделать
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Unit = EnumParser.Parse<UnitType>((string)reader["Unit"]),
                NutritionalValue = new NutritionalValue
                {
                    Protein = (int)reader["Protein"],
                    Fat = (int)reader["Fat"],
                    Carbohydrate = (int)reader["Carbohydrate"]
                }
            };
        }

        public Ingredient GetById(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM [Ingredient] WHERE [Id] = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                reader.Read();
                return MapIngredient(reader);
            };
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE [Ingredient] WHERE [Id] = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public IReadOnlyCollection<Ingredient> GetAll()
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                connection.Open();
                var list = new List<Ingredient>();
                var command = new SqlCommand("SELECT * FROM [dbo].[Ingredient]", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(MapIngredient(reader));
                }
                return list;
            };
        }

        public void Save(Ingredient ingredient)
        {
            using(var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO [dbo].[Indredient]([Name], [Protein], [Fat], [Carbohydrate]) VALUES (@name, @protein, @fat, @carbohydrate)", connection);
                command.Parameters.AddWithValue("@name", ingredient.Name);
                command.Parameters.AddWithValue("@protein", ingredient.NutritionalValue.Protein);
                command.Parameters.AddWithValue("@fat", ingredient.NutritionalValue.Fat);
                command.Parameters.AddWithValue("@carbohydrate", ingredient.NutritionalValue.Carbohydrate);
            }
        }

        public IReadOnlyCollection<Ingredient> GetAllByRecipeId(int recipeId)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                connection.Open();
                var list = new List<Ingredient>();
                var command = new SqlCommand("SELECT[dbo].[Ingredient].*, [dbo].[Unit].[Name] AS[Unit] FROM[dbo].[RecipeInfo]" + Typography.NewLine +
                                             "LEFT JOIN[dbo].[Ingredient] ON[dbo].[RecipeInfo].[IngredientId] = [dbo].[Ingredient].[Id]" + Typography.NewLine +
                                             "LEFT JOIN[dbo].[Unit] ON[dbo].[RecipeInfo].[UnitId] = [dbo].[Unit].[Id]" + Typography.NewLine +
                                             "WHERE[RecipeId] = @recipeId", connection);
                command.Parameters.AddWithValue("@recipeId", recipeId);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(MapIngredient(reader));
                }
                return list;
            }
        }
    }
}
