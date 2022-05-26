using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models
{
    internal class Transport : ITransport
    {
        public Transport(double weight, double height, int capacity, bool isWork, DateTime creationDate, string color, double price)
        {
            Weight = weight;
            Height = height;
            Capacity = capacity;
            IsWork = isWork;
            CreationDate = creationDate;
            Color = color;
            Price = price;
        }

        public double Weight { get; set; }

        public double Height { get; }

        public int Capacity { get; set; }
        public bool IsWork { get; set; }

        public DateTime CreationDate { get; }
        public double Speed { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public void Accelerate()
        {
            Speed = 30;
        }

        public void SlowDown()
        {
            Speed = 0;
        }
    }
}
