using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class HomeMain : ContentPage
{
	public HomeMain()
	{
		InitializeComponent();
		//BindingContext = new HomeViewModel(this);
	}

	//protected override void OnAppearing()
	//{
	//	base.OnAppearing();

 //       AppTheme currentTheme = Microsoft.Maui.Controls.Application.Current.RequestedTheme;

	//	if (currentTheme == AppTheme.Light)
	//	{
	//		MainActivity.SetPrimaryTheme();
	//	}
	//}
}