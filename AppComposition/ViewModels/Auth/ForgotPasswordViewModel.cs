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
    public partial class ForgotPasswordViewModel : BaseViewModel
    {
        ForgotPassword instance;

        [ObservableProperty]
        string email;

        public ForgotPasswordViewModel(ForgotPassword _instance)
        {
            instance = _instance;
        }

        [RelayCommand]
        public async Task SubmitEmail()
        {
            await instance.DisplayAlert("Dev", "Submitted wmail successfully.", "Ok");
        }
    }
}
