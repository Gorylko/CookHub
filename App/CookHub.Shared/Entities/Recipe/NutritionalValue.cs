namespace CookHub.Shared.Entities
{
    public class NutritionalValue
    {
        public int Protein { get; set; }

        public int Fat { get; set; }

        public int Carbohydrate { get; set; }

        public static NutritionalValue operator +(NutritionalValue value1, NutritionalValue value2)
        {
            return new NutritionalValue
            {
                Protein = value1.Protein + value2.Protein,
                Fat = value1.Fat + value2.Fat,
                Carbohydrate = value1.Carbohydrate + value2.Carbohydrate
            };
        }

        public static NutritionalValue operator -(NutritionalValue value1, NutritionalValue value2)
        {
            return new NutritionalValue
            {
                Protein = value1.Protein - value2.Protein,
                Fat = value1.Fat - value2.Fat,
                Carbohydrate = value1.Carbohydrate - value2.Carbohydrate
            };
        }

        public static NutritionalValue operator *(NutritionalValue value, double num)
        {
            return new NutritionalValue
            {
                Protein = (int)(value.Protein * num),
                Fat = (int)(value.Fat * num),
                Carbohydrate = (int)(value.Carbohydrate * num)
            };
        }

        public static NutritionalValue operator /(NutritionalValue value, double num)
        {
            return new NutritionalValue
            {
                Protein = (int)(value.Protein / num),
                Fat = (int)(value.Fat / num),
                Carbohydrate = (int)(value.Carbohydrate / num)
            };
        }
    }
}
