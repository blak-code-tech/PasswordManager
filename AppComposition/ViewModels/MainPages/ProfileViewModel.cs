using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        }

        [RelayCommand]
        public async Task Return()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
