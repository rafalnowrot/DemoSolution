using System;
using System.Collections.Generic;
using System.Text;
using DemoSolution.Core;
using DemoSolution.Infrastructure;
using Xunit;

namespace DemoSolution.IntegrationTests
{
    class ClientTest
    {
        private static ClientService _clientService = new ClientService();

        public void ShowClientTest()
        {
            // Arrange
            int id = 0;
            
            // Act
            var client = _clientService.GetClient(id);
            // Assert
            Assert.Equal('0', client.Id);

        }
    }
}
