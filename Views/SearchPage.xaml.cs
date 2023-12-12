using MauiTest2.ViewModels;

namespace MauiTest2.Views;

public partial class SearchPage : ContentPage
{
	public SearchPage(SearchViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}