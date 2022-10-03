using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManager.AppComposition.Views.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.AppComposition.ViewModels.Auth
{
    [INotifyPropertyChanged]
    public partial class LoginViewModel
    {
        LoginMain instance;
        public LoginViewModel(LoginMain _instance)
        {
            instance = _instance;
        }

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password = "";

        [ObservableProperty]
        bool passwordVisible = true;

        [RelayCommand]
        public async Task Login()
        {
            await instance.DisplayAlert("Dev", "Login working", "Ok");

            await Shell.Current.GoToAsync("///home");
        }

        [RelayCommand]
        public async Task ToRegistration()
        {
            await Shell.Current.GoToAsync("///registration");
        }
        
        [RelayCommand]
        public async Task ToForgotPassword()
        {
            await Shell.Current.GoToAsync("//login/forgotpassword");
        }
        
        [RelayCommand]
        public void TogglePassword()
        {
            PasswordVisible = !PasswordVisible;
        }
    }
}
