using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Business;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public Cars cars;

        public MainPage()
        {
            InitializeComponent();

            // Create an instance of CarRepository and assign it to _carRepository
            cars = new Cars();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var result = cars.Get(); // Get all cars from the repository

                Console.WriteLine(result);
                if (result != null)
                {
                    // Bind the list of cars to your UI elements for display
                    carListView.ItemsSource = (IEnumerable<Cars>)result.DataTable;
                }
                else
                {
                    Console.WriteLine("No cars found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }
    }
}
