using Microsoft.Maui.ApplicationModel;

namespace PasswordManager;

public partial class App : Application
{
	public App()
	{
        //Register Syncfusion license
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzQxNDUxQDMyMzAyZTMzMmUzMG0ydUgzMEJTcVhJRjhWMVVkR25CeXJVRUVHNHFhd3dLZGJJb0NwdTZONE09");

        InitializeComponent();

		MainPage = new AppShell();
	}

	protected override void OnStart()
	{
		base.OnStart();

		Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;
    }

    protected override void OnSleep()
    {
        base.OnSleep();
        Application.Current.RequestedThemeChanged -= Current_RequestedThemeChanged;
    }

    protected override void OnResume()
    {
        base.OnResume();
        Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;
    }


    private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
	{
        AppTheme currentTheme = e.RequestedTheme;

        MainThread.BeginInvokeOnMainThread(() =>
        {
            if (currentTheme == AppTheme.Unspecified || currentTheme == AppTheme.Light)
            {
#if __ANDROID__
                MainActivity.SetNavLightTheme();
#endif
            }
            else
            {
#if __ANDROID__
                MainActivity.SetNavDarkTheme();
#endif
            }
        });
	}
}
