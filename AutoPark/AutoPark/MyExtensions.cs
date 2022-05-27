using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoPark.Interfaces;

namespace AutoPark
{
    internal static class MyExtensions
    {
        /// <summary>
        /// Finds first passenger car in the car park with capacity 5 people.
        /// </summary>
        /// <param name="autoTransports">Array of auto`s object in the variable of IAutoTransport interface.</param>
        /// <returns>Object Auto in the interface variable that matches to conditions.</returns>
        public static IAutoTransport FirstPassengerAutoWithCapacity5(this IAutoTransport[] autoTransports)
        {
            for (int i = 0; i < autoTransports.Length; i++)
            {
                if (autoTransports[i].Capacity == 5 && autoTransports[i].IsPassenger)
                {
                    return autoTransports[i];
                }
            }

            return null;
        }
    }
}
