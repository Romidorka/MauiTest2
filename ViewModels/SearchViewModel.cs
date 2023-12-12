using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest2.Models;
using MauiTest2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.ViewModels
{
    public partial class SearchViewModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        [ObservableProperty] private string prompt;

        private IDataService _dataService;
        public SearchViewModel(IDataService dataService) 
        {
            _dataService = dataService;
        }

        [RelayCommand]
        private async Task DoSearch()
        {
            var emps = await _dataService.SearchEmployee(Prompt);
            Employees.Clear();
            foreach (var emp in emps)
            {
                Employees.Add(emp);
            }
        }
    }
}
