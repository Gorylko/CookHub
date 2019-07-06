using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Data.Repositories.Realization
{
    public class IngredientRepository : IIngredientRepository
    {
        private IIngredientContext _context;
        public IngredientRepository(IIngredientContext context)
        {
            this._context = context;
        }

        public IReadOnlyCollection<Ingredient> GetAllByRecipeId(int recipeId)
        {
            return _context.GetAllByRecipeId(recipeId);
        }

        public IReadOnlyCollection<Ingredient> GetAll()
        {
            return _context.GetAll();
        }

        public Ingredient GetById(int id)
        {
            return _context.GetById(id);
        }

        public void Delete(int id)
        {
            _context.Delete(id);
        }

        public void Save(Ingredient obj)
        {
            _context.Save(obj);
        }
    }
}
