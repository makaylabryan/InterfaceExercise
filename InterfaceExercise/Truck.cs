using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double TruckBedSize { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public int YearOfVehicle { get; set; }
        public string Logo { get; set; }
        public int AgeOfCompany { get; set; }
    }
}
