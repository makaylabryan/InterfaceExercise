using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV: IVehicle , ICompany
    {
        public int NumberOfSeats { get; set; }
        public double CargoSize { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public int YearOfVehicle { get; set; }
        public string Logo { get; set; }
        public int AgeOfCompany { get; set; }
    }
}
