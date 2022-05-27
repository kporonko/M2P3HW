using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Models.CarFirms
{
    internal class Mercedes : AutoTransport
    {
        public Mercedes(IEngine engine, bool istruck, string model, bool ispass, double weight, double height, int capacity, bool isWork, DateTime creationDate, string color, double price)
            : base(engine, istruck, ispass, model, weight, height, capacity, isWork, creationDate, color, price)
        {
        }
    }
}
