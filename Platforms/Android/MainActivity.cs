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
            SetLightTheme();
        }
        else if (currentTheme == AppTheme.Dark)
        {
            SetDarkTheme();
        }
    }

    public static void SetDarkTheme()
    {
        if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
        {
            return;
        }

        Instance.Window.DecorView.SystemUiVisibility = 0;
        Instance.Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(19, 15, 38));
        Instance.Window.SetStatusBarColor(Android.Graphics.Color.Rgb(19, 15, 38));
    }

    public static void SetPrimaryTheme()
    {
        if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
        {
            return;
        }

        Instance.Window.DecorView.SystemUiVisibility = 0;
        Instance.Window.SetStatusBarColor(Android.Graphics.Color.Rgb(35,41,122));
    }

    public static void SetStatusbarCustomColor(int color = 0)
    {
        if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
        {
            return;
        }

        if (color == 0)
        {
            Instance.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
            Instance.Window.SetStatusBarColor(Android.Graphics.Color.Rgb(245, 245, 245));
        }
        else if (color == 1)
        {
            Instance.Window.DecorView.SystemUiVisibility = 0;
            Instance.Window.SetStatusBarColor(Android.Graphics.Color.Rgb(35, 41, 122));
        }
    }
    
    public static void SetLightTheme()
    {
        if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
        {
            return;
        }

        Instance.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar | (StatusBarVisibility)SystemUiFlags.LightNavigationBar;
        Instance.Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(245,245,245));
        Instance.Window.SetStatusBarColor(Android.Graphics.Color.Rgb(245, 245, 245));
    }

}
