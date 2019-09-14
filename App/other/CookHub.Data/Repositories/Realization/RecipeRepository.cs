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
    public class RecipeRepository : IRecipeRepository
    {
        private IRecipeContext _context;
        public RecipeRepository(IRecipeContext context)
        {
            this._context = context ?? throw new NullReferenceException(nameof(context));
        }

        public void Delete(int id)
        {
            _context.Delete(id);
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            return _context.GetAll();
        }

        public IReadOnlyCollection<Recipe> GetAllByUserId(int userId)
        {
            return _context.GetAllByUserId(userId);
        }

        public Recipe GetById(int id)
        {
            return _context.GetById(id);
        }

        public void Save(Recipe obj)
        {
            _context.Save(obj);
        }
    }
}
