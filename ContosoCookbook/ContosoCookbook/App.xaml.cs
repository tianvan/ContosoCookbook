using ContosoCookbook.Views;
using ContosoCookbook.Services;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ContosoCookbook
{
    public partial class App : PrismApplication
    {
        public App() : this(null)
        {

        }

        public App(IPlatformInitializer initializer = null) : base(initializer)
        {

        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{nameof(LoginPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IRecipeService, RecipeService>();
            containerRegistry.Register<IAuthenticationService, AuthenticationService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<RecipePage>();
            containerRegistry.RegisterForNavigation<TestPage>();
            containerRegistry.RegisterForNavigation<LoginPage>();
        }
    }
}
