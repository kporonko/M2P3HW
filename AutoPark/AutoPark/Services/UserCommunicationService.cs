using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark
{
    internal class UserCommunicationService
    {
        public void Welcome(ICarPark park)
        {
            Console.WriteLine($"Our autopark {park.Name} includes {park.Autos.Length} cars.");
        }

        public void ParkPrice(double price)
        {
            Console.WriteLine($"Price of our park: {price}$");
        }

        public void CarOrCarsDescriptionString(string desc)
        {
            Console.WriteLine(desc);
        }
    }
}
