using ContosoCookbook.Services;
using Prism.Navigation;

namespace ContosoCookbook.ViewModels
{
    public class MainPageViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IRecipeService _recipeService;

        public MainPageViewModel(INavigationService navigationService, IRecipeService recipeService)
        {
            _navigationService = navigationService;
            _recipeService = recipeService;
        }
    }
}
