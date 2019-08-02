using DemoSolution.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                var commandText = "SELECT Id, FirstName, Surname, CreatedAt, CreatedBy FROM Clients";
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    using (var sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        clients = new List<Client>();
                        while (sqlDataReader.Read())
                        {
                            var client = new Client
                            {
                                Id = sqlDataReader.GetFieldValue<int>(0),
                                FirstName = sqlDataReader.GetFieldValue<string>(1),
                                Surname = sqlDataReader.GetFieldValue<string>(2),
                                CreatedAt = sqlDataReader.GetFieldValue<DateTime>(3),
                                CreatedBy = sqlDataReader.GetFieldValue<string>(4)
                            };
                            clients.Add(client);
                        }
                    }
                }
            }
            return clients;
        }

        public Client Get(int id)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = $"SELECT Id, FirstName, Surname, CreatedAt, CreatedBy FROM Clients where Id = {id}";
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                using (var sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (!sqlDataReader.HasRows)
                    {
                        return null;
                    }

                    sqlDataReader.Read();
                    return new Client
                    {
                        Id = sqlDataReader.GetFieldValue<int>(0),
                        FirstName = sqlDataReader.GetFieldValue<string>(1),
                        Surname = sqlDataReader.GetFieldValue<string>(2),
                        CreatedAt = sqlDataReader.GetFieldValue<DateTime>(3),
                        CreatedBy = sqlDataReader.GetFieldValue<string>(4)
                    };
                }
            }
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

        public void Update(int id, string newName, string newSurname)
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                var commandText = ($" UPDATE Clients SET FirstName = '{newName}', Surname = '{newSurname}'  WHERE Id = '{id}'");
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
                var commandText = ($"INSERT INTO Clients VALUES('{client.FirstName}','{client.Surname}','{client.CreatedAt:s}','{client.CreatedBy}')");
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
