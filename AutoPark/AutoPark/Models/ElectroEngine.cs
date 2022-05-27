using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models
{
    internal class ElectroEngine : Engine
    {
        public ElectroEngine(double power)
            : base(power)
        {
        }
    }
}
