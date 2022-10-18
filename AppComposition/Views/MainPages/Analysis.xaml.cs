using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class Analysis : BasePage
{
	public Analysis()
	{
		InitializeComponent();

		BindingContext = new AnalysisViewModel(this);
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