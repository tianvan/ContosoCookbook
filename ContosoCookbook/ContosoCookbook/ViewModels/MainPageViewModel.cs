using ContosoCookbook.Models;
using System.Collections.ObjectModel;
using ContosoCookbook.Services;
using Prism.Navigation;
using Prism.Commands;
using System;

namespace ContosoCookbook.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IRecipeService _recipeService;

        private ObservableCollection<RecipeGroup> _recipeGroups;

        public ObservableCollection<RecipeGroup> RecipeGroups
        {
            get => _recipeGroups;
            set => SetProperty(ref _recipeGroups, value);
        }

        private DelegateCommand<Recipe> _recipeSelectedCommand;
        public DelegateCommand<Recipe> RecipeSelectedCommand =>
            _recipeSelectedCommand ?? (_recipeSelectedCommand = new DelegateCommand<Recipe>(RecipeSelected));

        private async void RecipeSelected(Recipe recipe)
        {
            var p = new NavigationParameters
            {
                { "recipe", recipe }
            };

            await _navigationService.NavigateAsync("RecipePage", p);
        }

        void ExecuteCommandName(Recipe parameter)
        {

        }

        public MainPageViewModel(INavigationService navigationService, IRecipeService recipeService)
        {
            _navigationService = navigationService;
            _recipeService = recipeService;
        }

    }
}
