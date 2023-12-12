using MauiTest2.ViewModels;

namespace MauiTest2.Views;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

