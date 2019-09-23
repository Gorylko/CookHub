using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.DbContext.Interfaces;
using CookHub.Data.Mappers;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using MapStrategy = CookHub.Data.Mappers.RecipeMapStrategies;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeContext : IRecipeContext
    {
        private IExecutor _executor;

        public RecipeContext(IExecutor executor)
        {
            _executor = executor;
        }

        public Recipe GetById(int id)
        {
            var dataSet = _executor.ExecuteDataSet("sp_select_recipe_by_id", new Dictionary<string, object> {
                {"recipeId", id}
            });

            var mapper = new Mapper<DataSet, Recipe>() { Map = MapStrategy.MapRecipe };
            return mapper.Map(dataSet);
        }

        public void Delete(int id)
        {
            
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            return new List<Recipe> {
                new Recipe{Name = "Recipe One"},
                new Recipe{Name = "Recipe two"}
            };
        }

        public void Save(Recipe obj)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
