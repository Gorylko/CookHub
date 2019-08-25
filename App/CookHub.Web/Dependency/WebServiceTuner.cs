using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookHub.Business.Dependency;

namespace CookHub.Web.Dependency
{
    public static class WebServiceTuner
    {
        public static void Initialize(this IServiceCollection services)
        {
            services.AddBusinessDataDependency();
        }
    }
}
