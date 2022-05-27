using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models
{
    internal class FuelEngine : Engine
    {
        public FuelEngine(double power, string fueltype)
            : base(power)
        {
            FuelType = fueltype;
        }

        public string FuelType { get; set; }
    }
}
