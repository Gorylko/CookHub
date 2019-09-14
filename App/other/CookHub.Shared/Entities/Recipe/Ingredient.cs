using CookHub.Shared.Entities.Enums;

namespace CookHub.Shared.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public UnitType Unit { get; set; }

        public NutritionalValue NutritionalValue { get; set; }
    }
}
