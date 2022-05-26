using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark.Services
{
    internal class CarsDescriptionService
    {
        /// <summary>
        /// Method appends in the stringbuilder descriptions of all cars in car park.
        /// </summary>
        /// <param name="park">Cars park.</param>
        /// <returns>Description of all the cars.</returns>
        public string CarsOfParkDescription(ICarPark park)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"\nPark cars:\n");
            for (int i = 0; i < park.Autos.Length; i++)
            {
                stringBuilder.Append($"\n{park.Autos[i].GetType().Name}\nModel: {park.Autos[i].Model}\nColor: {park.Autos[i].Color}\nWeight: {park.Autos[i].Weight}\n" +
                    $"Height: {park.Autos[i].Height}\nPeople capacity: {park.Autos[i].Capacity}\n\n");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Method appends in the stringbuilder description of one particular car.
        /// </summary>
        /// <param name="autoTransport">Object of car in the variable of interface IAutoTransport.</param>
        /// <returns>Description of param car.</returns>
        public string CarDescription(IAutoTransport autoTransport)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"\nCar:\n");
                stringBuilder.Append($"\n{autoTransport.GetType().Name}\nModel: {autoTransport.Model}\nColor: {autoTransport.Color}\nWeight: {autoTransport.Weight}\n" +
                        $"Height: {autoTransport.Height}\nPeople capacity: {autoTransport.Capacity}\n\n");

                return stringBuilder.ToString();
            }
            catch (Exception)
            {
               return "We cannot understand description of which car do you want to see(";
            }
        }
    }
}
