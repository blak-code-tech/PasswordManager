using CommunityToolkit.Maui;
using SkiaSharp.Views.Maui.Controls.Hosting;
using Syncfusion.Maui.Core.Hosting;

namespace PasswordManager;

public static class MauiProgram
{
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

        return builder.Build();
	}
}
