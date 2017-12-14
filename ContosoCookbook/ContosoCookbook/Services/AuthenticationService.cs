using ContosoCookbook.Views;
using Prism.Navigation;
using ContosoCookbook.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCookbook.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly INavigationService _navigationService;

        public AuthenticationService(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public bool Login(string userName, string password)
        {
            if (password.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                Settings.Current.UserName = userName;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            Settings.Current.UserName = string.Empty;
            _navigationService.NavigateAsync(nameof(LoginPage));
        }
    }
}
