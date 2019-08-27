using CookHub.Shared.Entities;
using System.Data;

namespace CookHub.Data.Mappers
{
    internal class RecipeMapStrategies
    {
        internal static Recipe MapRecipe(DataRow recipeRow)
        {
            return new Recipe
            {
                Id = recipeRow.Field<int>("Id"),
                Name = recipeRow.Field<string>("Name"),
                Description = recipeRow.Field<string>("Description")
            };
        }

    }
}
