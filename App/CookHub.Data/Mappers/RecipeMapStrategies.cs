using CookHub.Shared.Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CookHub.Data.Mappers
{
    internal class RecipeMapStrategies
    {
        internal static Recipe MapRecipe(DataSet dataSet)
        {
            if(dataSet == null)
            {
                return default;
            }

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
                Images = ImageMapStrategies.MapImages(recipeImagesTable),
                Author = UserMapStrategies.MapUser(userRow)
            };
            recipe.Author.Images = ImageMapStrategies.MapImages(userImagesTable);
            return recipe;
        }

        internal static IReadOnlyCollection<Recipe> MapRecipeCollection(DataSet dataset)
        {
            return dataset.Tables[0].AsEnumerable().Select(row =>
                new Recipe
                {
                    Id = row.Field<int>("Id"),
                    Name = row.Field<string>("Name"),
                    Description = row.Field<string>("Description"),
                    Images = Enumerable.Range(0, 1).Select(image =>
                    new Image
                    {
                        Path = row.Field<string>("Path")
                    }
                    ).ToList()
                }).ToList();
        }
    }
}
