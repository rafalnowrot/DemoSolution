using DemoSolution.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DemoSolution.Infrastructure
{
    public class CarRepository
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=DemoSolution;Integrated Security=True;Pooling=False";

        public List<Car> Get()
        {
            List<Car> cars;

            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = "SELECT Id, BrandName, Model, ClientId, CreatedBy, CreatedAt FROM Cars";
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    using (var sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        cars = new List<Car>();
                        while (sqlDataReader.Read())
                        {
                            var car = new Car();
                            car.Id = sqlDataReader.GetFieldValue<Guid>(0);
                            car.BrandName = sqlDataReader.GetFieldValue<string>(1);
                            car.Model = sqlDataReader.GetFieldValue<string>(2);
                            car.ClientId = sqlDataReader.GetFieldValue<int>(3);
                            car.CreatedBy = sqlDataReader.GetFieldValue<string>(4);
                            car.CreatedAt = sqlDataReader.GetFieldValue<DateTime>(5);
                            cars.Add(car);
                        }
                    }
                }
            }
            return cars;
        }
    }
}