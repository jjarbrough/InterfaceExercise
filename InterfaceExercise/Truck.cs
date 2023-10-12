using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
       public bool hasBed {  get; set; }
       public bool hasHitch { get; set; }
        public int numberOfWheels { get; set; }
        public int numberOfHeadlights { get; set; }
        public bool engineWorks { get; set; }
        public bool hasWorkingBrakes { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
    }
}
