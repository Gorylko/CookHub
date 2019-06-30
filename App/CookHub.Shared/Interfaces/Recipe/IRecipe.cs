using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Interfaces.Recipe
{
    interface IRecipe
    {
        int Id { get; set; }

        string Name { get; set; }

        string Decription { get; set; }

        IReadOnlyCollection<RecipeImage> Images { get; set; }

        IReadOnlyCollection<Ingredient> Ingredients { get; set; }

        IUser Author { get; set; }
        //!!! due to this property, IUser interface have to be public
    }
}
