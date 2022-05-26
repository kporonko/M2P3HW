using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    internal interface IAutoTransport : ITransport
    {
        public IEngine Engine { get; set; }
        public string Model { get; }
        public bool IsTruck { get; }
        public bool IsPassenger { get; }
        public void Drive();
    }
}
