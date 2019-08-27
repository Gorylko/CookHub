using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CookHub.Data.DataContext.Realization.MsSqlServer
{
    public class RecipeImageContext : IRecipeImageContext
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Image obj)
        {
            throw new NotImplementedException();
        }
    }
}
