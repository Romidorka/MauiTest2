namespace MauiTest2.Views;

using MauiTest2.ViewModels;

public partial class DetailEmployeePage : ContentPage
{
	public DetailEmployeePage(DetailEmployeeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}