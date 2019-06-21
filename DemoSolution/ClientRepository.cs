using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DemoSolution
{
    public class ClientRepository
    {
        public List<string> Get()
        {
            var connectionString = "Data Source=localhost;Initial Catalog=DemoSolution;Integrated Security=True;Pooling=False";
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var commandText = "SELECT * FROM Clients";
                using (var sqlCommand = new SqlCommand(commandText, sqlConnection))
                {
                    using (var sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while(sqlDataReader.Read())
                        {
                            Console.WriteLine($"KLIENT {sqlDataReader.GetFieldValue<int>(0)}");
                            Console.WriteLine(sqlDataReader.GetFieldValue<string>(1));
                            Console.WriteLine(sqlDataReader.GetFieldValue<string>(2));
                            Console.WriteLine(sqlDataReader.GetFieldValue<string>(3));
                            Console.WriteLine(sqlDataReader.GetFieldValue<DateTime>(4));
                            Console.WriteLine(sqlDataReader.GetFieldValue<string>(5));
                            Console.WriteLine();
                        }
                    }
                }
            }
            // TODO
            return null;
        }
    }
}
