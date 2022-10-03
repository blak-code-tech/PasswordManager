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
    public partial class RegistrationViewModel : BaseViewModel
    {
        [ObservableProperty]
        //[NotifyCanExecuteChangedFor(nameof(GetSuggestionsCommand))]
        string name;

        [ObservableProperty]
        string password = "";

        [ObservableProperty]
        string email;
            
        [ObservableProperty]
        bool passwordVisible = true;

        private RegistrationMain instance;
        public RegistrationViewModel(RegistrationMain _instance)
        {
            instance = _instance;
        }

        [RelayCommand]
        private async Task Register()
        {
            await instance.DisplayAlert("Testing", "Testing the registration page.", "OK");
        }
        
        [RelayCommand]
        private async Task ToLoginPage()
        {
            await Shell.Current.GoToAsync("///login");
        }

        [RelayCommand]
        public void TogglePassword()
        {
            PasswordVisible = !PasswordVisible;
        }
    }
}
