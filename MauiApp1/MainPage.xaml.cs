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
            _ = LoadData(); 
        }

        private async Task LoadData()
        {
            // Call the static GetCars method to retrieve cars
            var result = await Task.Run(() => CarsData.GetCars()); 

            if (result != null && result.DataTable != null)
            {
                _cars = new List<Car>();

                foreach (DataRow row in result.DataTable.Rows)
                {
                    var car = new Car(
                        row["Make"].ToString(),
                        row["Model"].ToString(),
                        Convert.ToInt32(row["Year"]),
                        Convert.ToDecimal(row["Price"])
                    );
                    _cars.Add(car);
                }

                carListView.ItemsSource = _cars;
            }
        }
    }
}
