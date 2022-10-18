using PasswordManager.AppComposition.ViewModels.Auth;
using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class ForgotPassword : BasePage
{
	public ForgotPassword()
	{
		InitializeComponent();

		BindingContext = new ForgotPasswordViewModel(this);
	}
}