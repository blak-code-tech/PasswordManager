using PasswordManager.AppComposition.ViewModels.Onboarding;
using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager.AppComposition.Views.Onboarding;

public partial class OnboardingMain : BasePage
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