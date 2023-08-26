using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public Car() 
        { 
           
        }
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"This is how you drive a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
            Console.WriteLine($"The {vehicle.Model} has {NumberOfDoors} doors.");
            if (HasTrunk) 
            {
                Console.WriteLine($"The {vehicle.Model} also has a trunk for storage.");
            }
            else
            {
                Console.WriteLine($"The {vehicle.Model} Has no trunk for storage.");
            }
        }

    }
}
