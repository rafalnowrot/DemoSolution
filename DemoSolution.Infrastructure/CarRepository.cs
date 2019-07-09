﻿using DemoSolution.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;

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

        internal void Update(int id, string brandName, string model, int clientId)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = ($" UPDATE Cars SET BrandName = '{brandName}', Model = {model}, ClientId = {clientId} WHERE Id = '{id}'");
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        internal void Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = ($"Delete FROM Cars where Id = {id}");
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        internal void Add(Car car)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = ($"insert into Cars values('{car.BrandName}','{car.Model}','{car.ClientId}','{car.CreatedAt.ToString(CultureInfo.InvariantCulture)}','{car.CreatedBy}')");
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}