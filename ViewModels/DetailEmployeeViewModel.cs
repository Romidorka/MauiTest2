using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest2.Models;
using MauiTest2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.ViewModels
{
    [QueryProperty("Employee", "Employee")]
    public partial class DetailEmployeeViewModel : ObservableObject
    {
        [ObservableProperty] private Employee employee;
        [ObservableProperty] private string employeeName;
        [ObservableProperty] private string employeeSurname;
        [ObservableProperty] private int employeeAge;

        private IDataService _dataService;
        public DetailEmployeeViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        [RelayCommand]
        private async Task ApplyUpdate()
        {
            await _dataService.UpdateEmployee(new Employee(Employee.Id, EmployeeName, EmployeeSurname, EmployeeAge));
        }
    }
}
