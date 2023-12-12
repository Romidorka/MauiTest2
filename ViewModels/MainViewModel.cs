using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest2.Models;
using MauiTest2.Services;
using MauiTest2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IStorageService _storageService;
        [ObservableProperty] private ObservableCollection<string> buckets = new ObservableCollection<string>();

        public MainViewModel(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [RelayCommand]
        private async Task GetBuckets()
        {
           Buckets = (await _storageService.GetAllBuckets()).ToObservableCollection();            
        }
    }
}
