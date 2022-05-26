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
        public bool IsTruck { get; set; }
        public bool IsPassenger { get; set; }
        public void Drive();
    }
}
