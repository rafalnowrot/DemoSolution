using System;

namespace DemoSolution.Core
{
    public class Car
    {
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int ClientId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
