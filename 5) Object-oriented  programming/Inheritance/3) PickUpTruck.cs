using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class PickUpTruck : Car
    {
        public int bedLength;

        public PickUpTruck(int bedLength) : base()
        {
            this.bedLength = bedLength;
        }

        public PickUpTruck(string color,string brand,int bedLength):base(color,brand)
        {
            this.bedLength=bedLength;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h and its bed length is {bedLength}");
        }
    }
}
