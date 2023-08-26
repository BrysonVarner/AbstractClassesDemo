using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */


            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion

            /*
             * I commented out some of the features in order to improve readablity, 
             * but added them to the DriveAbstract WriteLines for more fun and a better 
             * appearance to the user. ~Bryson
             */
            var newCar1 = new Car();
            newCar1.NumberOfDoors = 2;
            newCar1.HasTrunk = true;
            newCar1.Year = "1989";
            newCar1.Make = "Ford";
            newCar1.Model = "Escort";
            //newCar1.DriveAbstract(newCar1);
            //newCar1.DriveVirtual(newCar1);
           
            var newMotorcycle1 = new Motorcycle();
            newMotorcycle1.EngineSize = "750";
            newMotorcycle1.HasWindShield = true;
            newMotorcycle1.Model = "Ninja";
            newMotorcycle1.Make = "Kawasaki";
            newMotorcycle1.Year = "1998";
            //newMotorcycle1.DriveAbstract(newMotorcycle1);
            //newMotorcycle1.DriveVirtual(newMotorcycle1);

            var newSemi1 =new Car();
            newSemi1.Year = "2014";
            newSemi1.Make = "Peterbuilt";
            newSemi1.Model = "Longhauler";
            newSemi1.NumberOfDoors = 3;
            newSemi1.HasTrunk = false;
            //newSemi1.DriveAbstract(newSemi1);
            //newSemi1.DriveVirtual(newSemi1);

            var newLawnmower = new Motorcycle();
            newLawnmower.Year = "1978";
            newLawnmower.Make = "John Deer";
            newLawnmower.Model = "Riding Mower";
            newLawnmower.EngineSize = "150";
            newLawnmower.HasWindShield = false;
            //newLawnmower.DriveAbstract(newLawnmower);
            //newLawnmower.DriveVirtual(newLawnmower);



            var vehicles = new List<Vehicle>();
            vehicles.Add(newCar1);
            vehicles.Add(newMotorcycle1);
            vehicles.Add(newSemi1);
            vehicles.Add(newLawnmower);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                vehicle.DriveAbstract(vehicle);
                vehicle.DriveVirtual(vehicle);
                Console.WriteLine("------------------------------------------------------");

            }
        }
    }
}
