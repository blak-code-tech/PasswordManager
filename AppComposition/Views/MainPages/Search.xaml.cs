namespace PasswordManager.AppComposition.Views.MainPages;

public partial class Search : ContentPage
{
	public Search()
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