using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class Profile : BasePage
{
	public Profile()
	{
		InitializeComponent();
        BindingContext = new ProfileViewModel(this);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (!Preferences.ContainsKey("uid"))
        {
            await Shell.Current.GoToAsync("///onboarding");
        }
    }
}