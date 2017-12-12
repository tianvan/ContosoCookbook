using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using ContosoCookbook.Models;

namespace ContosoCookbook.Services
{
    public interface IRecipeService
    {
        Task<IList<RecipeGroup>> GetRecipeGroupsAsync();
    }
}
