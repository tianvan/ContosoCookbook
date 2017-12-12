using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCookbook.ViewModels
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {

        }

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}
