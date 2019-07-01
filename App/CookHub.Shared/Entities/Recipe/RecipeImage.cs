<<<<<<< HEAD
﻿using CookHub.Shared.Interfaces.Recipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Entities
=======
﻿namespace CookHub.Shared.Entities
>>>>>>> feature/general_lib3.0
{
    public class RecipeImage : IRecipeImage
    {
        public int Id { get; set; }

<<<<<<< HEAD
        public string Path { get; set; }
      
=======
        public int RecipeId { get; set; }

        public string Path { get; set; }
>>>>>>> feature/general_lib3.0
    }
}
