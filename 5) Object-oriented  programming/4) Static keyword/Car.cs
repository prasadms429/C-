using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    internal class Car
    {
        private string color;   
        private string brand;   
        private int currentSpeed;
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
    }
}
