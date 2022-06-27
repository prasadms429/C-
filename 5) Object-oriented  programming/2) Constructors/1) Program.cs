using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.color = "red";
            Car1.brand = "Toyota";

            Car Car2 = new Car("green","Honda"); // constructor reduces lines of codes

            Car1.Accelerate(20);
            Car2.Accelerate(20);
            Car2.Deccelerate(10);

            Car1.DisplaySpeed();    // 20 km/h
            Car2.DisplaySpeed();    // 10 km/h

            Console.ReadKey();
        }
    }
}
