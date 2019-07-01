using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Interfaces
{
    public interface INutritionalValue
    {
        int Protein { get; set; }

        int Fat { get; set; }

        int Carbohydrate { get; set; }
    }
}
