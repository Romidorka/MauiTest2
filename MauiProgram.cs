using CommunityToolkit.Maui;
using MauiTest2.Models;
using MauiTest2.Services;
using MauiTest2.ViewModels;
using MauiTest2.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MauiTest2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			}).UseMauiCommunityToolkit();

		builder.Services.AddSingleton<Supabase.Client>(_ => new Supabase.Client(ApiConfig.Url, ApiConfig.ApiKey));

        //builder.Services.AddSingleton<IDataService, DataService>();
        builder.Services.AddSingleton<IStorageService, StorageService>();

        builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<MainPage>();

		builder.Services.AddTransient<DetailEmployeeViewModel>();
		builder.Services.AddTransient<DetailEmployeePage>();

		builder.Services.AddTransient<SearchViewModel>();
		builder.Services.AddTransient<SearchPage>();

		builder.Services.AddTransient<AuthViewModel>();
		builder.Services.AddTransient<AuthPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
