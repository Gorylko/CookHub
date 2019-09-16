using CookHub.Business.Services.Interfaces;
using CookHub.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CookHub.Web.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this._recipeService = recipeService ?? throw new NullReferenceException(nameof(recipeService));
        }

        public Recipe GetInfoById(int id)
        {
            return _recipeService.GetById(id);
        }
    }
}