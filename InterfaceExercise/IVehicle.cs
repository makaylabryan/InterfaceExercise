using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public bool CanDrive { get; set; }
        public int YearOfVehicle { get; set; }

    }
}
