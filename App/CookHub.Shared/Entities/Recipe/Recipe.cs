using CookHub.Shared.Interfaces;
using CookHub.Shared.Interfaces.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Entities
{
    public class Recipe : IRecipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Decription { get; set; }

        public IReadOnlyCollection<RecipeImage> Images { get; set; }

        public IReadOnlyCollection<Ingredient> Ingredients { get; set; }

        public IUser Author { get; set; }
    }
}
