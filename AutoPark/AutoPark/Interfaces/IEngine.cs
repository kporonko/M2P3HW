using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    internal interface IEngine
    {
        public string FuelType { get; set; }
        public double Volume { get; }
        public double CycindersCount { get; }
        public double Power { get; set; }
    }
}
