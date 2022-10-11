using PasswordManager.AppComposition.ViewModels.Auth;
using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class ResetPassword : BasePage
{
	public ResetPassword()
	{
		InitializeComponent();

		BindingContext = new ResetPasswordViewModel(this);
	}
}