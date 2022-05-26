using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    internal interface ICarPark
    {
        public string Name { get; set; }
        public IAutoTransport[] Autos { get; set; }
    }
}
