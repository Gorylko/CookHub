using CookHub.Shared.Entities;
using System.Data;

namespace CookHub.Data.Mappers
{
    internal class RecipeMapStrategies
    {
        internal static Recipe MapRecipe(DataSet dataSet)
        {
            var recipeRow = dataSet.Tables[0].Rows[0];
            var ingrTable = dataSet.Tables[1];
            var recipeImagesTable = dataSet.Tables[2];
            var userRow = dataSet.Tables[3].Rows[0];
            var userImagesTable = dataSet.Tables[4];

            var recipe = new Recipe
            {
                Id = recipeRow.Field<int>("Id"),
                Name = recipeRow.Field<string>("Name"),
                Description = recipeRow.Field<string>("Description"),
                Ingredients = IngredientMapStrategies.MapIngredients(ingrTable),
                Images = ImageMapStrategies.MapImages(recipeImagesTable)
            };
        }

    }
}
