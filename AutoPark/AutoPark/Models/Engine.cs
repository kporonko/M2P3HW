﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models
{
    internal class Engine : IEngine
    {
        public Engine(double power)
        {
            Power = power;
        }

        public double Power { get; set; }
    }
}
