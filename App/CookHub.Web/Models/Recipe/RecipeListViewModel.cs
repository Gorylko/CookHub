using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookHub.Web.Models
{
    public class RecipeListViewModel
    {
        public IReadOnlyCollection<Recipe> Recipes { get; set; }
    }
}
