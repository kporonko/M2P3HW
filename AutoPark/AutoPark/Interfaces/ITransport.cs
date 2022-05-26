using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark.Interfaces
{
    internal interface ITransport
    {
        public double Weight { get; set; }
        public double Height { get; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public bool IsWork { get; set; }
        public double Speed { get; set; }
        public DateTime CreationDate { get; }
        public void SlowDown();
        public void Accelerate();
    }
}
