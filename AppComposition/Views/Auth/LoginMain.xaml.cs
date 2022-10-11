using PasswordManager.AppComposition.ViewModels.Auth;
using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class LoginMain : BasePage
{
	public LoginMain()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel(this);
	}
}