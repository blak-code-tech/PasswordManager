using PasswordManager.AppComposition.ViewModels.Auth;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();

		BindingContext = new ForgotPasswordViewModel(this);
	}
}