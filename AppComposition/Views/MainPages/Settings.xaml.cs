using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class Settings : BasePage
{
	public Settings()
	{
		InitializeComponent();
		BindingContext = new SettingsViewModel(this);
	}
}