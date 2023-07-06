using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestingFoundationsWithDotNet
{
    public class Engine
    {
        public int Power { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public Engine(int power, int volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }
    }
}
