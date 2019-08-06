using DemoSolution.Core;
using System;
using System.Data.SqlClient;

namespace DemoSolution.Infrastructure.Repositories
{
    public class EmployeerRepository
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=DemoSolution;Integrated Security=True;Pooling=False";

        public Employeer Get(string email, string password)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = $"SELECT Id FROM Employeers WHERE Email = '{email}' and Password = '{password}' ";
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                using (var sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (!sqlDataReader.HasRows)
                    {
                        return null;
                    }

                    sqlDataReader.Read();
                    return new Employeer
                    {
                        Id = sqlDataReader.GetFieldValue<int>(0)
                    };
                }
            }
        }

        public Employeer GetOne(int employeerID)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = $"SELECT FirstName, Surname, Adress, City, Email, Password FROM Employeers WHERE Id = '{employeerID}' ";
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                using (var sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (!sqlDataReader.HasRows)
                    {
                        return null;
                    }

                    sqlDataReader.Read();
                    return new Employeer
                    {
                        FirstName = sqlDataReader.GetFieldValue<string>(1),
                        Surname = sqlDataReader.GetFieldValue<string>(2),
                        Adress = sqlDataReader.GetFieldValue<string>(3),
                        City = sqlDataReader.GetFieldValue<string>(4),
                        Email = sqlDataReader.GetFieldValue<string>(5),
                        Password = sqlDataReader.GetFieldValue<string>(6),
                    };
                }
            }
        }
    }
}