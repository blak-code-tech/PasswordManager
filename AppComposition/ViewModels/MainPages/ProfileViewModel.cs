using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManager.AppComposition.Services;
using PasswordManager.AppComposition.Services.Notification;
using PasswordManager.AppComposition.Views.Auth;
using PasswordManager.AppComposition.Views.MainPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.AppComposition.ViewModels.MainPages
{
    [INotifyPropertyChanged]
    public partial class ProfileViewModel
    {
        private readonly Profile instance;
        public ProfileViewModel(Profile _instance)
        {
            instance = _instance;

            setUserInfo();
        }

        private void setUserInfo()
        {
            DisplayName = Preferences.Default.Get<string>("display_name", "");
            Email = Preferences.Default.Get<string>("email", "");
        }

        [ObservableProperty]
        private string displayName;
        
        [ObservableProperty]
        private string email;

        [RelayCommand]
        public async Task Return()
        {
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task Logout()
        {
            var promptRes = await instance.DisplayAlert("Logout", "Are you sure you want to be logged out?", "Yes", "No");
            
            if (promptRes)
            {
                var res = await InAppAuthenticationServices.SignOutUser();

                if (res)
                {
                    await Shell.Current.GoToAsync("///login");
                }
                else
                {
                    await InAppNotification<Profile>.ShowSnackBarAsync(instance, "Something went wrong. Check your internet connection.");
                }
            }
        }
    }
}
