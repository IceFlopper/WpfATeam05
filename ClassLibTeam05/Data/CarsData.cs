using ClassLibRentStrumentTeam05.Data.Framework;
using ClassLibTeam05.Business.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClassLibTeam05.Data
{
    public class CarsData : SqlServer
    {
        public CarsData()
        {
            TableName = "Cars";
        }

        public string TableName { get; set; }

        public SelectResult Select()
        {
            return base.Select(TableName);
        }


        public static SelectResult GetCars()
        {
            // Create an instance of CarsData to perform database operations
            CarsData carsData = new CarsData();
            // Call the Select method to retrieve cars from the database
            SelectResult result = carsData.Select();
            return result;
        }

        public InsertResult Insert(Car car)
        {
            var result = new InsertResult();
            try
            {
                // SQL Command
                StringBuilder insertQuery = new StringBuilder();
                insertQuery.Append($"INSERT INTO {TableName} ");
                insertQuery.Append($"(Make, Model, Year, Price) VALUES ");
                insertQuery.Append($"(@make, @model, @year, @price); ");

                using (SqlCommand insertCommand = new SqlCommand(insertQuery.ToString()))
                {
                    // Add parameters for car properties
                    insertCommand.Parameters.Add("@make", SqlDbType.VarChar).Value = car.Make;
                    insertCommand.Parameters.Add("@model", SqlDbType.VarChar).Value = car.Model;
                    insertCommand.Parameters.Add("@year", SqlDbType.Int).Value = car.Year;
                    insertCommand.Parameters.Add("@price", SqlDbType.Decimal).Value = car.Price;

                    // Call the base class method to execute the SQL command
                    result = InsertRecord(insertCommand);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return result;
        }

    }
}
