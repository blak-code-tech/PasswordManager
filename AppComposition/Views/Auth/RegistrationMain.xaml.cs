using PasswordManager.AppComposition.ViewModels.Auth;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class RegistrationMain : ContentPage
{
	public RegistrationMain()
	{
		InitializeComponent();

		this.BindingContext = new RegistrationViewModel(this);
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
	}
}