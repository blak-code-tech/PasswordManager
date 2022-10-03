using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManager.AppComposition.Enums;
using PasswordManager.AppComposition.Model;
using PasswordManager.AppComposition.Views.MainPages;
using PasswordManager.Resources.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.AppComposition.ViewModels.MainPages
{
    [INotifyPropertyChanged]
    public partial class AnalysisViewModel
    {
        private readonly Analysis instance;

        [ObservableProperty]
        private bool isBusy = true;

        [ObservableProperty]
        List<Password> passwords;

        public AnalysisViewModel(Analysis _instance)
        {
            instance = _instance;
        }

        [RelayCommand]
        public void GetList()
        {
            Passwords = new List<Password>();

            Passwords = CreatePasswordsList();

            IsBusy = false;
        }

        public List<Password> CreatePasswordsList()
        {
            var passwords = new List<Password>
            {   new Password{
                    Icon = FontIcons.Netflix,
                    Title = "Netflix",
                    EmailOrUsername = "test@test.com",
                    PasswordStrengthValue = 89,
                    PasswordStrength = PasswordStrengthEnum.Safe
                },

                new Password{
                    Icon = FontIcons.Apple,
                    Title = "Apple",
                    EmailOrUsername = "LiveTester99",
                    PasswordStrengthValue = 35,
                    PasswordStrength = PasswordStrengthEnum.Weak
                },

                new Password{
                    Icon = FontIcons.Skype,
                    Title = "Skype",
                    EmailOrUsername = "realdeal@origin.com",
                    PasswordStrengthValue = 68,
                    PasswordStrength = PasswordStrengthEnum.Safe
                },
                new Password{
                    Icon = FontIcons.Spotify,
                    Title = "Spotify",
                    EmailOrUsername = "SweetTalk007",
                    PasswordStrengthValue = 99,
                    PasswordStrength = PasswordStrengthEnum.Strong
                },
            };

            return passwords;
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
