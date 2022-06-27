using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVsPrivate
{
    internal class Car
    {
        private string color;   // this is field
        private string brand;   // this is field
        private int currentSpeed; // this is field    // By declaring private, we cannot access the fields or methods outside the its class. 
                            //By using this type of class we can only use it and know its functionality and we cannot modify its inside fields or methods.

        public Car()         
        {
            currentSpeed = 0;   
        }

        public Car(string carColor, string carBrand) 
        {
            color = carColor;
            brand = carBrand;
            currentSpeed = 0;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color= color;  // this.color refers to field
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            if(isBrandValid(brand))
            {
                this.brand = brand;
            }
            else
            {
                Console.WriteLine("Invalid brand");
            }
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

        private bool isBrandValid(string brand)
        {
            List<string> brandNames = new List<string> { "Honda", "Toyota", "Ford" };
            if(brandNames.Contains(brand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
