using System;
using System.Collections.Generic;
using ClassLibRentStrumentTeam05.Data.Framework;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Data.Framework;
using ClassLibTeam05.Data.Repositories;
using System.Data.SqlClient; // Add this namespace for SqlCommand
using System.Data;
using System.Text;
using ClassLibTeam05.Data;

namespace ClassLibTeam05.Business
{
    public class Cars
    {
 
        public InsertResult Add(string make, string model, int year, decimal price)
        {

            Car car = new Car(make, model, year, price);

            CarsData carsData = new CarsData();
            return carsData.Insert(car);
        }


        public SelectResult Get()
        {
            CarsData carsData = new CarsData();

            return carsData.Select();
        }
    }
}
