namespace PasswordManager.AppComposition.Views.MainPages;

public partial class PasswordDetails : BasePage
{
	public PasswordDetails()
	{
		InitializeComponent();
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