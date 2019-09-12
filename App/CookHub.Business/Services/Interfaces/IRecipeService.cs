using CookHub.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookHub.Business.Services.Interfaces
{
    public interface IRecipeService : IService<Recipe>
    {
        IReadOnlyCollection<Recipe> GetAllByUserId(int id);
    }
}
