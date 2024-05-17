using System.Collections.Generic;
using System.Threading.Tasks;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Data.Repositories;
using ClassLibTeam05.Data;
using System.Data;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly CarRepository _carRepository;
        private List<Car> _cars;

        public MainPage(CarRepository carRepository)
        {
            _carRepository = carRepository;
            InitializeComponent();
            LoadData();
        }

        private async Task LoadData()
        {
            // Call the static GetCars method to retrieve cars
            var result = CarsData.GetCars();

            // Access the retrieved data from the DataTable property of SelectResult
            if (result != null && result.DataTable != null)
            {
                _cars = new List<Car>();

                // Convert DataTable rows to Car objects and add to the _cars list
                foreach (DataRow row in result.DataTable.Rows)
                {
                    // Assuming your Car constructor accepts parameters (make, model, year, price)
                    var car = new Car(
                        row["Make"].ToString(),
                        row["Model"].ToString(),
                        Convert.ToInt32(row["Year"]),
                        Convert.ToDecimal(row["Price"])
                    );
                    _cars.Add(car);
                }

                // Bind _cars list to your UI here
                // Example: carListView.ItemsSource = _cars;
            }
        }

        // Other methods and event handlers...

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Your existing code...
        }
    }
}
