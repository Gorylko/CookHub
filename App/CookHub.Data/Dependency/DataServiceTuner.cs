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
            services.AddSingleton<IRecipeRepository, RecipeRepository>();
            services.AddSingleton<IRecipeContext, RecipeContext>();
            services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}
