using CookHub.Business.Services.Interfaces;
using CookHub.Data.DataContext.Interfaces;
using CookHub.Data.Repositories.Interfaces;
using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;

namespace CookHub.Business.Services
{
    public class IngredientService : IIngredientService
    {
        private IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository repository)
        {
            this._ingredientRepository = repository ?? throw new NullReferenceException(nameof(repository));
        }

        public Ingredient GetById(int id)
        {
            return _ingredientRepository.GetById(id);
        }

        public IReadOnlyCollection<Ingredient> GetAll()
        {
            return _ingredientRepository.GetAll();
        }

        public IReadOnlyCollection<Ingredient>GetAllByRecipeId(int recipeId)
        {
            return _ingredientRepository.GetAllByRecipeId(recipeId);
        }

        public void Detele(int id)
        {
            _ingredientRepository.Delete(id);
        }

        public void Save (Ingredient ingredient)
        {
            _ingredientRepository.Save(ingredient);
        }

        public void Delete(int id)
        {
            _ingredientRepository.Delete(id);
        }
    }
}
