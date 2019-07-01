using CookHub.Shared.Interfaces;
using CookHub.Shared.Interfaces.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System.Collections.Generic;
>>>>>>> feature/general_lib3.0

namespace CookHub.Shared.Entities
{
    public class Recipe : IRecipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Decription { get; set; }

        public IReadOnlyCollection<RecipeImage> Images { get; set; }

        public IReadOnlyCollection<Ingredient> Ingredients { get; set; }

<<<<<<< HEAD
        public IUser Author { get; set; }
=======
        public NutritionalValue NutritionalValue {
            get {
                var value = new NutritionalValue();
                foreach(var el in Ingredients)
                {
                    value += el.NutritionalValue;
                }
                return value;
            }
        }

        public User Author { get; set; }
>>>>>>> feature/general_lib3.0
    }
}
