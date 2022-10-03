using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class Profile : BasePage
{
	public Profile()
	{
		InitializeComponent();
        BindingContext = new ProfileViewModel(this);
    }
}