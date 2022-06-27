using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLecture
{
    internal class Car
    {
        public string color;
        public string brand;
        public int currentSpeed;

        public Car()        // non-parametraised constructor
        {
            currentSpeed = 0;   // Constructor initializes values when an object is created and we dont need to intialize it again and again.
        }

        public Car(string carColor,string carBrand) // paramatrised constructor
        {
            color = carColor;
            brand = carBrand;
            currentSpeed = 0;
        }

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
