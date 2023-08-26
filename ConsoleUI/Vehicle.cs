using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public abstract void DriveAbstract(Vehicle vehicle);
        
        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"You put the {Model} in drive, and turn the wheel to steer.");
            Console.WriteLine($"This is how you drive a {Year} {Make} {Model}.");
        }
    }
}
