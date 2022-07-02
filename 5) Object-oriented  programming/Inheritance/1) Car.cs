using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Car
    {
        protected string color; // protected keyword is used in inheritance. By using this, variable can be accessed in both in its own class and inherited classes.
        protected string brand;
        protected int currentSpeed;
        static private int numCarObjects = 0;

        public Car()
        {
            currentSpeed = 0;
            numCarObjects++;
        }

        public Car(string carColor, string carBrand)
        {
            color = carColor;
            brand = carBrand;
            currentSpeed = 0;
            numCarObjects++;
        }

        static public int GetNumCarObjects()
        {
            return numCarObjects;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void Accelerate(int increaseSpeed)
        {
            currentSpeed += increaseSpeed;
        }

        public void Deccelerate(int decreaseSpeed)
        {
            currentSpeed -= decreaseSpeed;
        }

        public virtual void DisplayInfo() // To accesses methods from base class in derived classes, but it is to work differently than base class, we use this 'virtual' in base class and 'overide' in derived class
        {
            Console.WriteLine($"The {color} {brand} is travelling at {currentSpeed} km/h");
        }
    }
}
