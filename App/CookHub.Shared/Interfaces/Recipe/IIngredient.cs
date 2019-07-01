using CookHub.Shared.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Shared.Interfaces
{
    public interface IIngredient
    {
        int Id { get; set; }

        string Name { get; set; }

        int Amount { get; set; }

        UnitType Unit { get; set; }
    
    }
}
