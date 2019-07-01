using CookHub.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.Constants
{
    public static class SqlConstants
    {
        public const string ConnectionString = "Data Source=LAPTOP-P3338OQH;Initial Catalog=CookHubDB;Integrated Security=True";

        public const string SelectAllIngredients = "SELECT * FROM [dbo].[RecipeInfo]" + Typography.NewLine +
            "LEFT JOIN[dbo].[Ingredient] ON[dbo].[RecipeInfo].[IngredientId] = [dbo].[Ingredient].[Id]" + Typography.NewLine +
            "LEFT JOIN [dbo].[Unit] ON [dbo].[RecipeInfo].[UnitId] = [dbo].[Unit].[Id]";
    }
}
