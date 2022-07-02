using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*RaceCar myRaceCar = new RaceCar();
            myRaceCar.useNumNitros();
            myRaceCar.Deccelerate(5);

            PickUpTruck myPickUpTruck = new PickUpTruck();
            myPickUpTruck.Accelerate(10);
            myPickUpTruck.bedLength = 100;

            Console.ReadKey();*/

            /*RaceCar myRaceCar = new RaceCar(5);
            RaceCar myRaceCar2 = new RaceCar("Red", "Toyota", 5);

            Console.ReadKey();*/

            Car myCar = new Car("Green","Suzuki");
            myCar.DisplayInfo();

            RaceCar myRaceCar = new RaceCar("Red", "Toyota", 5);
            myRaceCar.DisplayInfo();

            PickUpTruck myPickUpTruck = new PickUpTruck("Blue", "Honda", 100);
            myPickUpTruck.DisplayInfo();

            Console.ReadKey();
        }
    }
}
