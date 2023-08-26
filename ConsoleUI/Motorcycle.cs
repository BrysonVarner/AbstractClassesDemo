using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasWindShield { get; set; }
        public string EngineSize { get; set; }

        public override void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"You put the {vehicle.Model} in gear, release the clutch, and turn the handlebars to steer.");            
        }
        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"This is how you drive a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
            Console.WriteLine($"The {vehicle.Model} has a {EngineSize} cc engine.");
            if ( HasWindShield )
            {
                Console.WriteLine($"The {vehicle.Model} has a windshield to protect you.");
            }
            else 
            {
                Console.WriteLine($"The {vehicle.Model} has no windshield to protect you.");
            }
        }

    }
    

}
