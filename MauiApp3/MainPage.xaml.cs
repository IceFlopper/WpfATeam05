using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;
using ClassLibTeam05.Data.Repositories;
using ClassLibTeam05.Business.Entities;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private readonly CarRepository _carRepository;

        public MainPage(CarRepository carRepository)
        {
            InitializeComponent();
            _carRepository = carRepository;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var cars = _carRepository.GetAll(); // Get all cars from the repository

                if (cars != null && cars.Any())
                {
                    // Bind the list of cars to your UI elements for display
                    carListView.ItemsSource = cars;
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

        // Other methods and event handlers if any...
    }
}
