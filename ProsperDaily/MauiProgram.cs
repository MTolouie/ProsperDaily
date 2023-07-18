using Microsoft.Extensions.Logging;
using ProsperDaily.MVVM.Models;
using ProsperDailyTests.Repositories;
using Syncfusion.Maui.Core.Hosting;

namespace ProsperDaily;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("LibreFranklin-Regular", "Regular");
				fonts.AddFont("Roboto-Black.ttf", "Strong");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddScoped<BaseRepository<Transaction>,BaseRepository<Transaction>>();

		return builder.Build();
	}
}
