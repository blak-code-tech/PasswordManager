using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Home : BasePage
{
	public Home()
	{
		InitializeComponent();

		BindingContext = new HomeViewModel(this);
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