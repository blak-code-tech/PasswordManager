using CommunityToolkit.Maui;
using MetroLog.MicrosoftExtensions;
using PasswordManager.AppComposition.Views.MainPages;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using PasswordManager.AppComposition.Statics;

namespace PasswordManager;

public static class MauiProgram
{
		//<OutputType Condition = "'$(TargetFramework)' != 'net6.0'" > Exe </ OutputType >

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureSyncfusionCore()
			.UseSkiaSharp()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("BebasNeue-Regular.ttf", "BebasNeueRegular");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("md-icons.ttf", "AppIcons");
			});

        AppCenter.Start($"windowsdesktop={AppConstants.AppCenterWinKey};" +
                $"android={AppConstants.AppCenterDroidKey};" +
                $"ios={AppConstants.AppCenterIOSKey};" +
                $"macos={AppConstants.AppCenterMacOsKey};",
                typeof(Analytics), typeof(Crashes));

        builder.Logging.AddTraceLogger(_ => {});
		builder.Logging.AddInMemoryLogger(_ => {});
		builder.Logging.AddStreamingFileLogger(_ => {});
		builder.Services.AddTransient<Profile>();
        return builder.Build();
	}
}
