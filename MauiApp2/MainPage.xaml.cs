using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using ClassLibTeam05.Business.Entities;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public List<Car> Cars { get; set; }
        private readonly HttpClient _httpClient;

        public MainPage()
        {
            InitializeComponent();
            Cars = new List<Car>();
            _httpClient = new HttpClient();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                string apiUrl = "https://rs55zc8r-7025.euw.devtunnels.ms/api/Car"; // Replace with your actual API endpoint
                Cars = await GetCarsFromApi(apiUrl);

                // Bind the list of cars to your UI elements for display
                carListView.ItemsSource = Cars;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        private async Task<List<Car>> GetCarsFromApi(string apiUrl)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<ApiResponse<Car>>(apiUrl);
                return response?.DataTable ?? new List<Car>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data from API: {ex.Message}");
                return new List<Car>();
            }
        }
    }
}
