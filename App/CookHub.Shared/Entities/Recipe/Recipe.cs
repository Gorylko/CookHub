using CookHub.Shared.Interfaces;
using System.Collections.Generic;

namespace CookHub.Shared.Entities
{
    public class Recipe : IRecipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Decription { get; set; }

        public IReadOnlyCollection<RecipeImage> Images { get; set; }

        public IReadOnlyCollection<Ingredient> Ingredients { get; set; }

        public INutritionalValue NutritionalValue {
            get {
                var value = new NutritionalValue();
                foreach(var el in Ingredients)
                {
                    value += el.NutritionalValue;
                }
                return value;
            }
        }

        public IUser Author { get; set; }
    }
}
