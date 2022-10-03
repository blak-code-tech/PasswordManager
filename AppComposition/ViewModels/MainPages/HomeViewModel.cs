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
    public partial class HomeViewModel
    {
        private readonly Home instance;

        [ObservableProperty]
        private bool isBusy = true;

        [ObservableProperty]
        private bool isMainPage = true;

        [ObservableProperty]
        List<PasswordGroup> passwords;

        public HomeViewModel(Home _instance)
        {
            instance = _instance;
        }

        [RelayCommand]
        public void GetList()
        {
            Passwords = new List<PasswordGroup>();

            Passwords = CreatePasswordsList();

            IsBusy = false;
        }

        public List<PasswordGroup> CreatePasswordsList()
        {

            var passwordsGroup = new List<PasswordGroup>();

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

            passwordsGroup.Add(new PasswordGroup("Priority", passwords));
            passwordsGroup.Add(new PasswordGroup("Entertainment", passwords));
            passwordsGroup.Add(new PasswordGroup("Social", passwords));
            passwordsGroup.Add(new PasswordGroup("Gaming", passwords));

            return passwordsGroup;
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
