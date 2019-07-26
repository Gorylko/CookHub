using CookHub.Data.DbContext.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CookHub.Shared.Entities;
using CookHub.Shared.Entities.Enums;
using CookHub.Shared.Helpers;

namespace CookHub.ConsoleTester.Worker
{
    public class DbWorker
    {
        private string ConnectionString { get; set; }

        private IExecutor _executor { get; set; }
        public DbWorker(string connectionString, IExecutor executor)
        {
            this.ConnectionString = connectionString;
            this._executor = executor;
        }


        private Recipe MapRecipe(DataRow recipeRow, DataTable ingredientsTable, DataTable imagesTable, DataRow userRow)
        {
            return new Recipe
            {
                Id = recipeRow.Field<int>("Id"),
                Name = recipeRow.Field<string>("Name"),
                Description = recipeRow.Field<string>("Description"),
                Author = MapUser(userRow),
                Ingredients = MapIngredients(ingredientsTable),
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

        private User MapUser(DataRow userRow)
        {
            return new User
            {
                Id = userRow.Field<int>("Id"),
                Login = userRow.Field<string>("Login"),
                Email = userRow.Field<string>("Email"),
                PhoneNumber = userRow.Field<string>("PhoneNumber"),
                Role = (RoleType)userRow.Field<int>("RoleId")
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
    }
}
