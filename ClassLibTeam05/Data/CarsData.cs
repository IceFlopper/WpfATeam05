using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ClassLibRentStrumentTeam05.Data.Framework;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Data.Framework;

namespace ClassLibTeam05.Data
{
    internal class CarsData : SqlServer
    {

        public CarsData()
        {
            TableName = "Cars";
        }

        public static string TableName { get; set; }

        public SelectResult Select()
        {
            // Implement your SQL SELECT operation using _sqlServer
            string query = $"SELECT * FROM {TableName}";

            SqlCommand cmd = new SqlCommand(query);
            return Select(cmd);
        }


        public InsertResult Insert(Car car)
        {
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
                    return InsertRecord(insertCommand);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
