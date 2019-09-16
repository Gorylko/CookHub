using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookHub.Business.Dependency;
using CookHub.Business.Services.Interfaces;
using CookHub.Business.Services;

namespace CookHub.Web.Dependency
{
    public static class ServiceTuner
    {
        public static void Initialize(this IServiceCollection services)
        {
            services.AddTransient<IRecipeService, RecipeService>();
            services.AddBusinessDataDependency();
        }
    }
}
