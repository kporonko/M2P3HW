using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Models.CarFirms;

namespace AutoPark.Models
{
    internal class CarPark : ICarPark
    {
        public CarPark(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public IAutoTransport[] Autos { get; set; } = new IAutoTransport[3];
        private IEngine[] Engines { get; set; } = new IEngine[3];

        public void FillAutos()
        {
            FillEngines();
            Autos[0] = new Mercedes(Engines[0], false, "E 200", true, 1665, 1852, 5, true, new DateTime(1992, 10, 22), "silver", 8000);
            Autos[1] = new Nissan(Engines[1], false, true, "Leaf", 1365, 1852, 5, true, new DateTime(2012, 10, 21), "black", 15000);
            Autos[2] = new Zaporozhets(Engines[2], true, false, "968", 3665, 2852, 6, false, new DateTime(1982, 10, 25), "red", 4000);
        }

        private void FillEngines()
        {
            Engines[0] = new FuelEngine(136, "diesel");
            Engines[1] = new Engine(120);
            Engines[2] = new FuelEngine(40, "diesel");
        }
    }
}
