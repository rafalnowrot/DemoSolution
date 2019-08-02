using DemoSolution.Core;
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
    }
}