using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models.CarFirms
{
    internal class Zaporozhets : AutoTransport
    {
        public Zaporozhets(IEngine engine, bool istruck, bool ispass, string model, double weight, double height, int capacity, bool isWork, DateTime creationDate, string color, double price)
            : base(engine, istruck, ispass, model, weight, height, capacity, isWork, creationDate, color, price)
        {
        }
    }
}
