using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Entities;
using System.Collections.Generic;

namespace CookHub.Business.Services.Recipe
{
    public class IngredientService
    {
        private IDataContext<Ingredient> _ingredientContext;

        public IngredientService(IDataContext<Ingredient> context)
        {
            this._ingredientContext = context;
        }

        public Ingredient GetById(int id)
        {
            return _ingredientContext.GetById(id);
        }

        public IReadOnlyCollection<Ingredient> GetAll()
        {
            return _ingredientContext.GetAll();
        }

        public void Detele(int id)
        {
            _ingredientContext.Delete(id);
        }

        public void Save (Ingredient ingredient)
        {
            _ingredientContext.Save(ingredient);
        }
    }
}
