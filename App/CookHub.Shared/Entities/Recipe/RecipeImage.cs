using CookHub.Shared.Interfaces.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Entities
{
    public class RecipeImage : IRecipeImage
    {
        public int Id { get; set; }

        public string Path { get; set; }
      
    }
}
