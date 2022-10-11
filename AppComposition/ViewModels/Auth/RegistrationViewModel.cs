using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using PasswordManager.AppComposition.Helpers.Statics;
using PasswordManager.AppComposition.Helpers.Validations.Rules;
using PasswordManager.AppComposition.Services;
using PasswordManager.AppComposition.Views.Auth;

namespace PasswordManager.AppComposition.ViewModels.Auth
{
    [INotifyPropertyChanged]
    public partial class RegistrationViewModel
    {
        private readonly IsEmailRule<string> validator = new IsEmailRule<string>();

        [ObservableProperty]
        bool isValidEmail;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
        string name;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
        string password = "";

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
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
            if (ValidateEmail())
            {
                try
                {
                    var userCredentials = await InAppAuthenticationServices.SignUpUserWithEmailAndPassword(Email, Password, Name);
                    await instance.DisplaySnackbar("Check email");
                    await Shell.Current.GoToAsync("///login");
                }
                catch (FirebaseAuthHttpException ex)
                {
                    await StaticMethods<RegistrationMain>.HandleFirebaseAuthError(instance, ex.Reason, ex.Message);
                }

            }
            else
            {
                await instance.DisplaySnackbar("Invalid input");
            }

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

        private bool ValidateEmail()
        {
            return validator.Check(Email);
        }
    }
}
