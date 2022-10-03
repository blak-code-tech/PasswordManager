using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManager.AppComposition.Model;
using PasswordManager.AppComposition.Views.Auth;
using PasswordManager.AppComposition.Views.Onboarding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.AppComposition.ViewModels.Onboarding
{
    [INotifyPropertyChanged]
    public partial class OnboardingViewModel : BaseViewModel
    {
        private OnboardingMain _instance;
        public List<OnboardingModel> OnboardingItems { get; set; }

        public OnboardingViewModel(OnboardingMain instance)
        {
            _instance = instance;

            OnboardingItems = CreateOnboardingList();
        }

        private List<OnboardingModel> CreateOnboardingList()
        {
            var list = new List<OnboardingModel>
            {
                new OnboardingModel
                {
                    HeaderText1 = "Generate ",
                    HeaderText2 = "Secure ",
                    HeaderText3 = "Passwords.",
                    SubText = "Stop using unsecure passwords for your online accounts, level up with OnePass. Get the most secure and difficult-to-crack passwords."
                },
                new OnboardingModel
                {
                    HeaderText1 = "ALL YOUR ",
                    HeaderText2 = "PASSWORDS ",
                    HeaderText3 = "ARE HERE.",
                    SubText = "Store and manage all of your passwords from one place. Don’t remember hundreds of passwords, just remember one."
                },
                new OnboardingModel
                {
                    HeaderText1 = "DON’T TYPE, ",
                    HeaderText2 = "AUTOFILL ",
                    HeaderText3 = "YOUR CREDENTIALS.",
                    SubText = "Don’t compromise your passwords by typing them in public, let OnePass autofill those and keep your credentials secure."
                }

            };

            return list;
        }

        [RelayCommand]
        private async Task GotoRegistrationPage()
        {
            await Shell.Current.GoToAsync("///registration");
        }

        [RelayCommand]
        private async Task GotoLoginPage()
        {
            await Shell.Current.GoToAsync("///login");
        }
    }
}
