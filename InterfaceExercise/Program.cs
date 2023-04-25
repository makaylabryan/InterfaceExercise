using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany     DONE

            //Create 3 classes called Car , Truck , & SUV      DONE

            //In your IVehicle     DONE
            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany   ---DONE
            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes      DONE
            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car Kia = new Car()
            {
                Model = "Forte",
                HasATrunk = true,
                IsAHybrid = false,
                NumberOfWheels = 4,
                CanDrive = true,
                YearOfVehicle = 2015,
                Logo = "Kia",
                AgeOfCompany = 50,
            };
            Console.WriteLine($"Model: {Kia.Model}; Has a trunk? {Kia.HasATrunk}; It's a hybrid: {Kia.IsAHybrid};");
            Console.WriteLine($"Number of wheels: {Kia.NumberOfWheels}; It can drive: {Kia.CanDrive}; Year: {Kia.YearOfVehicle};");
            Console.WriteLine($"Make: {Kia.Logo}, Age of Company: {Kia.AgeOfCompany}");
            Console.WriteLine("");

            SUV Hyundai = new SUV()
            {
                Model = "Santa Fe",
                NumberOfSeats = 7,
                CargoSize = 8,
                NumberOfWheels = 4,
                CanDrive = true,
                YearOfVehicle = 2009,
                Logo = "Hyundai",
                AgeOfCompany = 38,
            };
            Console.WriteLine($"Model: {Hyundai.Model}; Has a trunk? {Hyundai.CargoSize}; It's a hybrid: {Hyundai.NumberOfSeats};");
            Console.WriteLine($"Number of wheels: {Hyundai.NumberOfWheels}; It can drive: {Hyundai.CanDrive}; Year: {Hyundai.YearOfVehicle};");
            Console.WriteLine($"Make: {Hyundai.Logo}; Age of Company: {Hyundai.AgeOfCompany}");
            Console.WriteLine("");

            Truck Ford = new Truck()
            {
                Model = "F-150",
                TruckBedSize = 18,
                NumberOfWheels = 6,
                NumberOfDoors = 3,
                CanDrive = true,
                YearOfVehicle = 2022,
                Logo = "Ford",
                AgeOfCompany = 176,
                   
            };
            Console.WriteLine($"Model: {Ford.Model}; Has a trunk? {Ford.TruckBedSize}; It's a hybrid: {Ford.NumberOfDoors};");
            Console.WriteLine($"Number of wheels: {Ford.NumberOfWheels}; It can drive: {Ford.CanDrive}; Year: {Ford.YearOfVehicle};");
            Console.WriteLine($"Make: {Ford.Logo}; Age of Company: {Ford.AgeOfCompany}");
            Console.WriteLine("");
        }
    }
}
