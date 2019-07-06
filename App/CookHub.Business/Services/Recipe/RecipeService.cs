using CookHub.Data.Repositories.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookHub.Business.Services
{
    public class RecipeService
    {
        private IRecipeRepository _recipeRepository;
        public RecipeService(IRecipeRepository repository)
        {
            this._recipeRepository = repository;
        }

        public void Delete(int id)
        {
            _recipeRepository.Delete(id);
        }

        public IReadOnlyCollection<Recipe> GetAll()
        {
            return _recipeRepository.GetAll();
        }

        public IReadOnlyCollection<Recipe> GetAllByUserId(int userId)
        {
            return _recipeRepository.GetAllByUserId(userId);
        }

        public Recipe GetById(int id)
        {
            return _recipeRepository.GetById(id);
        }

        public void Save(Recipe obj)
        {
            _recipeRepository.Save(obj);
        }
    }
}
