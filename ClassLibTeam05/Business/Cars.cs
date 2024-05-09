using System;
using System.Collections.Generic;
using ClassLibRentStrumentTeam05.Data.Framework;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Data;
using ClassLibTeam05.Data.Repositories;

namespace ClassLibTeam05.Business
{
    public static class Cars
    {
        public static IEnumerable<Car> List()
        {
            return CarRepository.CarList;
        }
        public static InsertResult Add(string make, string model, int year, decimal price)
        {
            Car car = new Car(make, model, year, price);

            CarsData carsData = new CarsData();
            InsertResult result = carsData.Insert(car);
            return result;
        }


    }

}
