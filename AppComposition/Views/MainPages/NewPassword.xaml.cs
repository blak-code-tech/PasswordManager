using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class NewPassword : BasePage
{
	public NewPassword()
	{
		InitializeComponent();

		BindingContext = new NewPasswordViewModel(this);
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