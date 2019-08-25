using CookHub.Business.Services;
using CookHub.Business.Services.Interfaces;
using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.DataContext.Realization.MsSqlServer;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Data.Repositories.Realization;
using Microsoft.Extensions.DependencyInjection;
using CookHub.Data.Dependency;

namespace CookHub.Business.Dependency
{
    public static class BusinessServiceTuner
    {
        public static void AddBusinessDataDependency(this IServiceCollection services)
        {
            services.AddTransient<IRecipeService, RecipeService>();
            services.AddDataDependency();
        }
    }
}