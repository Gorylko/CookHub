using System.Collections.Generic;

namespace CookHub.Shared.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Decription { get; set; }

        public IReadOnlyCollection<RecipeImage> Images { get; set; }

        public IReadOnlyCollection<Ingredient> Ingredients { get; set; }

        public NutritionalValue NutritionalValue {
            get {
                var value = new NutritionalValue(); //container here
                foreach(var el in Ingredients)
                {
                    value += el.NutritionalValue;
                }
                return value;
            }
        }

        public User Author { get; set; }
    }
}
