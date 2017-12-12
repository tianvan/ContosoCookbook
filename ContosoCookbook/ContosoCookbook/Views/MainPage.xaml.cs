using ContosoCookbook.Models;
using ContosoCookbook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContosoCookbook.Views
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            ((MainPageViewModel)BindingContext).RecipeSelectedCommand.Execute((Recipe)args.Item);
        }
    }
}
