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
    public partial class NewPasswordViewModel
    {
        private readonly NewPassword instance;

        public NewPasswordViewModel(NewPassword newPassword)
        {
            instance = newPassword;
        }

        [RelayCommand]
        public async Task Return()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
