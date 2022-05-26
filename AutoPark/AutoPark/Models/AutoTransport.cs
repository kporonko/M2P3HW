using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models
{
    internal class AutoTransport : Transport, IAutoTransport
    {
        public AutoTransport(IEngine engine, bool istruck, bool ispass, string model, double weight, double height, int capacity, bool isWork, DateTime creationDate, string color, double price)
            : base(weight, height, capacity, isWork, creationDate, color, price)
        {
            Engine = engine;
            IsPassenger = ispass;
            IsTruck = istruck;
            Model = model;
        }

        public IEngine Engine { get; set; }
        public string Model { get; }
        public bool IsTruck { get; }
        public bool IsPassenger { get; }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
