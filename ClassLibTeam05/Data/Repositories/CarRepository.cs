using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibTeam05.Business.Entities;

namespace ClassLibTeam05.Data.Repositories
{
    static class CarRepository
    {
        static CarRepository()
        {
            CarList = new List<Car>();
            DefaultData();
        }

        private static void DefaultData()
        {
            Add("Toyota", "Camry", 2022, 25000);
            Add("Honda", "Accord", 2021, 27000);
        }

        public static List<Car> CarList { get; set; }

        public static void Add(string make, string model, int year, decimal price)
        {
            Car car = new Car(make, model, year, price);
            Add(car);
        }




        private static void Add(Car car)
        {
            CarList.Add(car);
        }
    }
}
