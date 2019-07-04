using CookHub.Data.DataContext.Interfaces;
using CookHub.Shared.Interfaces;
using System.Collections.Generic;

namespace CookHub.Business.Services.Recipe
{
    public class IngredientService
    {
        private IDataContext<IIngredient> _ingredientContext;

        public IngredientService(IDataContext<IIngredient> context)
        {
            this._ingredientContext = context;
        }

        public IIngredient GetById(int id)
        {
            return _ingredientContext.GetById(id);
        }

        public IReadOnlyCollection<IIngredient> GetAll()
        {
            return _ingredientContext.GetAll();
        }

        public void Detele(int id)
        {
            _ingredientContext.Delete(id);
        }

        public void Save (IIngredient ingredient)
        {
            _ingredientContext.Save(ingredient);
        }
    }
}
