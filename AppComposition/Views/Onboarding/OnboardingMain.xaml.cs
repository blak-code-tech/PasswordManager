using PasswordManager.AppComposition.ViewModels.Onboarding;

namespace PasswordManager.AppComposition.Views.Onboarding;

public partial class OnboardingMain : ContentPage
{
	public OnboardingMain()
	{
		InitializeComponent();

		BindingContext = new OnboardingViewModel(this);
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}