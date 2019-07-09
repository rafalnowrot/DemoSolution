using DemoSolution.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;

namespace DemoSolution.Infrastructure
{
    public class ClientRepository
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=DemoSolution;Integrated Security=True;Pooling=False";

        public List<Client> Get()
        {
            List<Client> clients;

            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = "SELECT Id, FirstName, Surname, PlateName, CreatedAt, CreatedBy FROM Clients";
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    using (var sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        clients = new List<Client>();
                        while (sqlDataReader.Read())
                        {
                            var client = new Client();
                            client.Id = sqlDataReader.GetFieldValue<int>(0);
                            client.FirstName = sqlDataReader.GetFieldValue<string>(1);
                            client.Surname = sqlDataReader.GetFieldValue<string>(2);
                            client.PlateName = sqlDataReader.GetFieldValue<string>(3);
                            client.CreatedAt = sqlDataReader.GetFieldValue<DateTime>(4);
                            client.CreatedBy = sqlDataReader.GetFieldValue<string>(5);
                            clients.Add(client);
                        }
                    }
                }
            }
            return clients;
        }

        public void Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = ($"DELETE FROM Clients WHERE Id = {id}");
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void Update(int id, string newNumber)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = ($" UPDATE Clients SET PlateName = '{newNumber}' WHERE Id = '{id}'");
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void Add(Client client)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = ($"INSERT INTO Clients VALUES('{client.FirstName}','{client.Surname}','{client.PlateName}','{client.CreatedAt.ToString(CultureInfo.InvariantCulture)}','{client.CreatedBy}')");
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
