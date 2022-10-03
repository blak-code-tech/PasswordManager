using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Home : BasePage
{
	public Home()
	{
		InitializeComponent();

		BindingContext = new HomeViewModel(this);
	}
}