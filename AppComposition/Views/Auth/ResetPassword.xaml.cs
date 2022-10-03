using PasswordManager.AppComposition.ViewModels.Auth;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class ResetPassword : ContentPage
{
	public ResetPassword()
	{
		InitializeComponent();

		BindingContext = new ResetPasswordViewModel(this);
	}
}