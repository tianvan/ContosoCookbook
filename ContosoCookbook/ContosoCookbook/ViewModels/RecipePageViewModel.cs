using ContosoCookbook.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCookbook.ViewModels
{
    public class RecipePageViewModel : ViewModelBase, INavigatingAware
    {
        private Recipe _recipe;
        public Recipe Recipe
        {
            get => _recipe;
            set => SetProperty(ref _recipe, value);
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("recipe"))
                Recipe = (Recipe)parameters["recipe"];
        }
    }
}
