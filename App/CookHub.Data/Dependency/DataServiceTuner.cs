using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.DataContext.Realization.MsSqlServer;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Data.Repositories.Realization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookHub.Data.Dependency
{
    public static class DataServiceTuner
    {
        public static void AddDataDependency(this IServiceCollection services)
        {
            //repository
            services.AddTransient<IRecipeRepository, RecipeRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            //context
            services.AddTransient<IRecipeContext, RecipeContext>();
            services.AddTransient<IRecipeImageContext, RecipeImageContext>();
            services.AddTransient<IIngredientContext, IngredientContext>();
            services.AddTransient<IUserContext, UserContext>();
            services.AddTransient<IUserImageContext, UserImageContext>();
        }
    }
}
