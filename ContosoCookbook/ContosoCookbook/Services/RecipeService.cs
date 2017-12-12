using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ContosoCookbook.Models;
using Newtonsoft.Json;

namespace ContosoCookbook.Services
{
    public class RecipeService : IRecipeService
    {
        public async Task<IList<RecipeGroup>> GetRecipeGroupsAsync()
        {
            var name = typeof(RecipeService).AssemblyQualifiedName.Split(',')[1].Trim();
            var assembly = Assembly.Load(new AssemblyName(name));
            Stream stream = assembly.GetManifestResourceStream(name + ".Data.RecipeData.json");

            using (var reader = new StreamReader(stream))
            {
                var json = await reader.ReadToEndAsync();
                var obj = new { Groups = new List<RecipeGroup>() };
                var result = JsonConvert.DeserializeAnonymousType(json, obj);
                return result.Groups;
            }
        }
    }
}
