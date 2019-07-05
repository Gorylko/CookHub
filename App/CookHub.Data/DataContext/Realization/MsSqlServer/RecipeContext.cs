using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeContext : IDataContext<Recipe>
    {
        private Recipe MapRecipe(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recipe GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Recipe obj)
        {
            throw new NotImplementedException();
        }
    }
}
