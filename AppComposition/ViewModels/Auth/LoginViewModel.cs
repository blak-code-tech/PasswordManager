using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using PasswordManager.AppComposition.Helpers.Statics;
using PasswordManager.AppComposition.Helpers.Validations.Rules;
using PasswordManager.AppComposition.Services;
using PasswordManager.AppComposition.Services.Notification;
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
        private readonly IsEmailRule<string> validator = new IsEmailRule<string>();

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string email = "";

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
        private string password = "";

        [ObservableProperty]
        bool passwordVisible = true;

        private LoginMain instance;
        public LoginViewModel(LoginMain _instance)
        {
            instance = _instance;
        } 

        [RelayCommand]
        public async Task Login()
        {
            if(!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
            {
                if (ValidateEmail())
                {
                    try
                    {
                        var userCred = await InAppAuthenticationServices.SignInUserWithEmailAndPassword(Email, Password);

                        if (userCred != null)
                        {
                            var res = await InAppAuthenticationServices.SaveUserCredentialInformation(userCred);

                            if (res)
                            {
                                await Shell.Current.GoToAsync("///home");
                            }
                            else
                            {
                                await InAppAuthenticationServices.SignOutUser();
                                await InAppNotification<LoginMain>.ShowSnackBarAsync(instance, "Something went wrong. Check your internet connectivity.");
                            }
                        }
                    }
                    catch (FirebaseAuthHttpException ex)
                    {
                        await StaticMethods<LoginMain>.HandleFirebaseAuthError(instance, ex.Reason, ex.Message);
                    }     
                }
                else
                {
                    await InAppNotification<LoginMain>.ShowSnackBarAsync(instance, "You have entered an incorrect email.");
                }
            }
            else
            {
                await InAppNotification<LoginMain>.ShowSnackBarAsync(instance, "Make sure to enter your email and password.");
            }
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

        private bool ValidateEmail()
        {
            return validator.Check(Email);
        }
    }
}
