using PasswordManager.AppComposition.ViewModels.Auth;
using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager.AppComposition.Views.Auth;

public partial class RegistrationMain : BasePage
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