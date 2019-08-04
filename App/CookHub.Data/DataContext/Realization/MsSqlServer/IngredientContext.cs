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
using System.Data;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class IngredientContext : IIngredientContext
    {
        public IReadOnlyCollection<Ingredient> MapIngredients(DataTable table)
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

        public Ingredient GetById(int id)
        {
            throw new Exception();
        }

        public void Delete(int id)
        {
            throw new Exception();
        }

        public IReadOnlyCollection<Ingredient> GetAll()
        {
            throw new Exception();
        }

        public void Save(Ingredient ingredient)
        {
            throw new Exception();
        }

        public IReadOnlyCollection<Ingredient> GetAllByRecipeId(int recipeId)
        {
            throw new Exception();
        }
    }
}
