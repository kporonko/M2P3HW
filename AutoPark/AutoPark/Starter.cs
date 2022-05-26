using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;
using AutoPark.Models;
using AutoPark.Services;

namespace AutoPark
{
    internal class Starter
    {
        public static void Run()
        {
            // Creating all the instances we need to work with.
            UserCommunicationService userCommunicationService = new UserCommunicationService();
            ICarPark park = new CarPark("Park1");
            CarParkService carParkService = new CarParkService();
            CarsDescriptionService carsDescriptionService = new CarsDescriptionService();

            (park as CarPark).FillAutos();
            userCommunicationService.Welcome(park);

            // Counting price of park`s cars.
            double parkPrice = carParkService.AutoParkPrice(park);
            userCommunicationService.ParkPrice(parkPrice);

            // Telling description of park`s cars.
            string carsDesc = carsDescriptionService.CarsOfParkDescription(park);
            userCommunicationService.CarOrCarsDescriptionString(carsDesc);

            // Sorting park`s autos by weight.
            carParkService.SortAutosByWeight(park);
            string carsDescSorted = carsDescriptionService.CarsOfParkDescription(park);
            userCommunicationService.CarOrCarsDescriptionString(carsDescSorted);

            // Using extension method to find the auto with particular criteries.
            IAutoTransport autoExtention = park.Autos.FirstPassengerAutoWithCapacity5();
            string passengerAutoCapacity5 = carsDescriptionService.CarDescription(autoExtention);
            userCommunicationService.CarOrCarsDescriptionString(passengerAutoCapacity5);
        }
    }
}
