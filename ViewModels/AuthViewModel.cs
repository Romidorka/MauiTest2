using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest2.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiTest2.Models
{
    [Serializable]
    public class AuthExeption { 
        public string error { get; set; }
        public string error_description { get; set; }
    }
}

namespace MauiTest2.ViewModels
{
    public partial class AuthViewModel : ObservableObject
    {
        readonly Supabase.Client _client;

        [ObservableProperty] private string login;
        [ObservableProperty] private string password;
        [ObservableProperty] private string error;

        public AuthViewModel(Supabase.Client client) {
            _client = client;
        }

        [RelayCommand]
        private async Task Auth()
        {
            if(Login == null || Password == null)
            {
                Error = "Fields are empty!!!";
                return;
            }

            try {
                var session = await _client.Auth.SignIn(Login, Password);
                Error = "Done!";
            }
            catch(Exception e) {
                Error = JsonSerializer.Deserialize<AuthExeption>(e.Message).error_description;
            }
        }
    }
}
