using DemoSolution.Core;
using DemoSolution.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace DemoSolution.IntegrationTests
{
    public class FileRepositoryTests
    {
        [Fact]
        public void SaveAsTxtTest()
        {
            // Arrange
            var clients = new List<Client>
            {
                new Client
                {
                    CreatedAt = new DateTime(2019,9,25),
                    CreatedBy = "TEST_CREATOR",
                    FirstName = "TEST_FIRST_NAME",
                    Id = 0,
                    Surname = "TEST_SURNAME"
                }
            };

            // Act
            string filePath = "C:\\Users\\dell\\source\\repos\\DemoSolution\\DemoSolution.IntegrationTests\\FileTest\\";
            FileRepository.SaveAsTxt(clients, filePath);

            // Assert
            var file = $"{filePath}\\Listaklientow\\plik.txt";
            Assert.Contains("TEST_SURNAME", file);
            
        }
    }
}
