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
        public App(IPlatformInitializer initializer=null):base(initializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IRecipeService, RecipeService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
