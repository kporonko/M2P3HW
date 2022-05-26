using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Models;
using AutoPark.Models.CarFirms;

namespace AutoPark.Services
{
    /// <summary>
    /// Class does all work with car park.
    /// </summary>
    internal class CarParkService
    {
        /// <summary>
        /// Method gets the overall price of all park`s cars.
        /// </summary>
        /// <param name="park">Cars park.</param>
        /// <returns>Overall cars price.</returns>
        public double AutoParkPrice(ICarPark park)
        {
            double sum = 0;
            foreach (var auto in park.Autos)
            {
                sum += auto.Price;
            }

            return sum;
        }

        /// <summary>
        /// Method sorts park cars autos by weight.
        /// </summary>
        /// <param name="park">Cars park.</param>
        public void SortAutosByWeight(ICarPark park)
        {
            park.Autos = park.Autos.OrderBy(x => x.Weight).ToArray();
        }
    }
}
