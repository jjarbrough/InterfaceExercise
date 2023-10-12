using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool hasTrunk { get; set; }
        public bool hasBackSeat { get; set; }
        public int numberOfWheels { get; set; }
        public int numberOfHeadlights { get; set; }
        public bool engineWorks { get; set; }
        public bool hasWorkingBrakes { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
    }
}
