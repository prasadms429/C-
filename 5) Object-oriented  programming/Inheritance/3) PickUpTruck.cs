using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class RaceCar : Car
    {
        private int numNitros = 5;

        public RaceCar(int numNitros) : base()
        {
            this.numNitros = numNitros;
        }

        public RaceCar(string color,string brand,int numNitros): base(color,brand)
        {
            this.numNitros=numNitros;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h and has {numNitros} nitros");
        }

        public void useNumNitros()
        {
            if(numNitros>0)
            {
                Accelerate(20);
            }
            else
            {
                Console.WriteLine("Out of nitros!");
            }
        }
    }
}
