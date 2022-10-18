using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class Settings : BasePage
{
	public Settings()
	{
		InitializeComponent();
		BindingContext = new SettingsViewModel(this);
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