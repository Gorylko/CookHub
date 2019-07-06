using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookHub.Business.Services;
using CookHub.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookHub.Web.Controllers
{
    public class RecipeController : Controller
    {
        private RecipeService _recipeService = new RecipeService();
        public IActionResult ShowRecipeList()
        {
            var model = new RecipeListViewModel { Recipes = _recipeService.GetAll() };
            return View(model);
        }

        public IActionResult ShowRecipeInfo(int recipeId)
        {
            var model = _recipeService.GetById(recipeId);
            return View(model);
        }
    }
}