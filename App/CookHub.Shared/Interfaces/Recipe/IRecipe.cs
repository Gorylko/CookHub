using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Interfaces
{
    public interface IRecipe
    {
        int Id { get; set; }

        string Name { get; set; }

        string Decription { get; set; }

        IReadOnlyCollection<RecipeImage> Images { get; set; }

        IReadOnlyCollection<Ingredient> Ingredients { get; set; }

        INutritionalValue NutritionalValue { get; }

        IUser Author { get; set; }
    }
}
