using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class NewPassword : BasePage
{
	public NewPassword()
	{
		InitializeComponent();

		BindingContext = new NewPasswordViewModel(this);
	}
}