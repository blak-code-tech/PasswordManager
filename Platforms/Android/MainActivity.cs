using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using static Android.Content.Res.Resources;
using Window = Android.Views.Window;

namespace PasswordManager;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    static MainActivity Instance;

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
        Window.ClearFlags(WindowManagerFlags.TranslucentStatus);
        Instance = this;
        SetAppTheme();
    }

    public static void SetAppTheme()
    {
        AppTheme currentTheme = Microsoft.Maui.Controls.Application.Current.RequestedTheme;


        if (currentTheme == AppTheme.Light)
        {
            SetNavLightTheme();
        }
        else if (currentTheme == AppTheme.Dark)
        {
            SetNavDarkTheme();
        }
    }

    public static void SetNavDarkTheme()
    {
        if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
        {
            return;
        }

        Instance.Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(19, 15, 38));
    }

    public static void SetNavLightTheme()
    {
        if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
        {
            return;
        }

        Instance.Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(245,245,245));
    }

}
