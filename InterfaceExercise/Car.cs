using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasATrunk { get; set; }
        public bool IsAHybrid { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public int YearOfVehicle { get; set; }
        public string Logo { get; set; }
        public int AgeOfCompany { get; set; }
    }
}
