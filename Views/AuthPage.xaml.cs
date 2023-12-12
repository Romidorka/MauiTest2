using MauiTest2.ViewModels;

namespace MauiTest2.Views;

public partial class AuthPage : ContentPage
{
	public AuthPage(AuthViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}