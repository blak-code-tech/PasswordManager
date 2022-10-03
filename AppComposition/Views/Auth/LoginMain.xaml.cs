using PasswordManager.AppComposition.ViewModels.Auth;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class LoginMain : ContentPage
{
	public LoginMain()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel(this);
	}
}