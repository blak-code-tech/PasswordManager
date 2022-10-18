using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManager.AppComposition.Views.Auth;

namespace PasswordManager.AppComposition.ViewModels.Auth
{
    [INotifyPropertyChanged]
    public partial class ForgotPasswordViewModel
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

        [RelayCommand]
        public async Task Return()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
