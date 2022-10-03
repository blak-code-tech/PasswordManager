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
    public partial class ResetPasswordViewModel
    {
        ResetPassword instance;

        [ObservableProperty]
        string password;

        public ResetPasswordViewModel(ResetPassword _instance)
        {
            instance = _instance;
        }

        [RelayCommand]
        public async Task SubmitPassword() 
        {
            await instance.DisplayAlert("Dev", "This is a test for reset password", "Ok");
        }
    }
}
