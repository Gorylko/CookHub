using System;
using System.Collections.Generic;
using System.Text;
using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.DataContext.Realization.MsSqlServer;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Data.Repositories.Realization;
using CookHub.Shared.Entities;
using StructureMap;

namespace CookHub.Data.Dependency
{
    class DataRegistry : Registry
    {
        public DataRegistry()
        {
            For<IRecipeContext>().Use<RecipeContext>();
            For<IIngredientContext>().Use<IngredientContext>();
            For<IDataContext<User>>().Use<UserContext>();

            For<IIngredientRepository>().Use<IngredientRepository>();
            For<IRecipeRepository>().Use<RecipeRepository>();
            For<IRepository<User>>().Use<UserRepository>();
        }
    }
}
