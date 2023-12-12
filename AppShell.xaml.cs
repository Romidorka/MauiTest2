using MauiTest2.Views;

namespace MauiTest2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(DetailEmployeePage), typeof(DetailEmployeePage));
		Routing.RegisterRoute(nameof(SearchPage), typeof(SearchPage));
		Routing.RegisterRoute(nameof(AuthPage), typeof(AuthPage));
    }
}
