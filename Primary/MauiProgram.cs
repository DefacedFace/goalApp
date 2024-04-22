using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using The49.Maui.BottomSheet;

namespace Primary;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseBottomSheet()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("WorkSans-Black.ttf", "WorkSansBlack");
				fonts.AddFont("HindGuntur-Medium.ttf", "HindGunturMeduim");
				fonts.AddFont("Cabin-Medium.ttf", "CabinMedium");
				fonts.AddFont("Inter-Medium.ttf", "InterMeduim");
				fonts.AddFont("Inter-Regular.ttf", "InterRegular");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
