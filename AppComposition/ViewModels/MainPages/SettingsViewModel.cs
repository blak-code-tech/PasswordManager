using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using PasswordManager.AppComposition.Views.MainPages;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.AppComposition.ViewModels.MainPages
{
    [INotifyPropertyChanged]
    public partial class SettingsViewModel
    {
        private readonly Settings instance;
        public SettingsViewModel(Settings instance)
        {
            this.instance = instance;
        }

        [RelayCommand]
        public async Task ToDetailPage(object page)
        {
            //await instance.DisplayAlert("Dev", "Going to profile", "OK");
            await Shell.Current.GoToAsync($"/{page}");
        }

        [RelayCommand]
        public async Task ToNewPassword()
        {
            await Shell.Current.GoToAsync("/newpassword");
        }

        [RelayCommand]
        public async Task ToProfile()
        {
            await Shell.Current.GoToAsync("/profile");
        }

    }
}
