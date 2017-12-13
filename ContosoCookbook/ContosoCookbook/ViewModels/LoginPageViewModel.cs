using Prism.Services;
using ContosoCookbook.Views;
using Xamarin.Forms;
using Prism.Navigation;
using ContosoCookbook.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;

namespace ContosoCookbook.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private IAuthenticationService _authenticationService;
        private INavigationService _navigationService;
        private IPageDialogService _pageDialogService;


        private string _userName;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand, CanExecuteLoginCommand)
            .ObservesProperty(() => UserName)
            .ObservesProperty(() => Password));

        public LoginPageViewModel(IAuthenticationService authenticationService, INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _authenticationService = authenticationService;
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }

        private async void ExecuteLoginCommand()
        {
            IsBusy = true;
            if (_authenticationService.Login(UserName, Password))
            {
                await _navigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
            }
            else
            {
                await _pageDialogService.DisplayAlertAsync("登陆失败", "用户名或密码错误！", "取消");
            }
        }

        private bool CanExecuteLoginCommand => !string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password) && IsNotBusy;
    }
}
