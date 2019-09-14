using CookHub.Shared.Entities;
using CookHub.Shared.Entities.Enums;
using CookHub.Shared.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CookHub.Data.Mappers
{
    internal class IngredientMapStrategies
    {
        internal static IReadOnlyCollection<Ingredient> MapIngredients(DataTable table)
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

    }
}
