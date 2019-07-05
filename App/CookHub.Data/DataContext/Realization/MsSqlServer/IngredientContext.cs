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
    public class IngredientContext : IDataContext<Ingredient>
    {
        private Shared.Entities.Ingredient MapIngredient(SqlDataReader reader)
        {
            Ingredient ingredient = new Ingredient();//тут пихать контейнеркую хрень          
            NutritionalValue nutritionalValue = new NutritionalValue();//и тут тожЫ

            ingredient.Id = (int)reader["IngredientId"];
            ingredient.Name = (string)reader["Name"];
            ingredient.Amount = (int)reader["Amount"];
            ingredient.Unit = EnumParser.Parse<UnitType>((string)reader["Unit"]);

            nutritionalValue.Protein = (int)reader["Protein"];
            nutritionalValue.Fat = (int)reader["Fat"];
            nutritionalValue.Carbohydrate = (int)reader["Carbohydrate"];

            ingredient.NutritionalValue = nutritionalValue;
            return ingredient;
        }

        public Ingredient GetById(int id)
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
                var command = new SqlCommand(SqlConst.SelectAllIngredients + Typography.NewLine + "WHERE [Id] = @id", connection);
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
                var command = new SqlCommand("DELETE [Ingredient] WHERE [Id] = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public IReadOnlyCollection<Ingredient> GetAll()
        {
            using (var connection = new SqlConnection(SqlConst.ConnectionString))
            {
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
                var command = new SqlCommand("INSERT INTO [dbo].[Indredient]([Name], [Protein], [Fat], [Carbohydrate]) VALUES (@name, @protein, @fat, @carbohydrate)", connection);
                command.Parameters.AddWithValue("@name", ingredient.Name);
                command.Parameters.AddWithValue("@protein", ingredient.NutritionalValue.Protein);
                command.Parameters.AddWithValue("@fat", ingredient.NutritionalValue.Fat);
                command.Parameters.AddWithValue("@carbohydrate", ingredient.NutritionalValue.Carbohydrate);
            }
        }
    }
}
