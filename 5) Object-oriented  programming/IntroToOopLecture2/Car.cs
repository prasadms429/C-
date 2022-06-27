using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOopLecture2
{
    internal class Car
    {
        public string color;
        public string brand;
        public int currentSpeed;

        public void Accelerate(int increaseSpeed)
        {
            currentSpeed += increaseSpeed;
        }

        public void Deccelerate(int decreaseSpeed)
        {
            currentSpeed -= decreaseSpeed;
        }

        public void DisplaySpeed()
        {
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h");
        }
    }
}
