using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models
{
    internal class Engine : IEngine
    {
        public Engine(string fuelType, double volume, double cycinders, double power)
        {
            FuelType = fuelType;
            Volume = volume;
            CycindersCount = cycinders;
            Power = power;
        }

        public string FuelType { get; set; }

        public double Volume { get; }

        public double CycindersCount { get; }

        public double Power { get; set; }
    }
}
