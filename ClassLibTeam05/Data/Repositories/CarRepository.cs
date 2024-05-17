using System;
using System.Collections.Generic;
using ClassLibTeam05.Business.Entities;

namespace ClassLibTeam05.Data.Repositories
{
    public class CarRepository
    {
        public CarRepository()
        {
            CarList = new List<Car>();
            DefaultData();
        }

        private void DefaultData()
        {
            Add(new Car("Toyota", "Camry", 2022, 25000));
            Add(new Car("Honda", "Accord", 2021, 27000));
        }

        public List<Car> CarList { get; set; }

        public void Add(string make, string model, int year, decimal price)
        {
            Car car = new Car(make, model, year, price);
            Add(car);
        }

        public void Add(Car car)
        {
            CarList.Add(car);
        }

        public IEnumerable<Car> GetAll()
        {
            return CarList;
        }
    }
}
