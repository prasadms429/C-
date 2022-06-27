using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOopLecture
{
    class Lamp
    {
        public string color;
        public bool isOn;

        public void TurnOn()
        {
            isOn = true;
        }
        public void TurnOff()
        {
            isOn = false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp1=new Lamp();
            Lamp lamp2=new Lamp();
            Lamp lamp3 = new Lamp();

            lamp1.color = "green";
            lamp1.isOn = true;

            lamp2.color = "blue";
            lamp2.isOn = false;

            lamp3.color = "red";
            lamp3.isOn = true;

            Console.WriteLine(lamp1.isOn);  // outputs True
            lamp1.TurnOff();
            Console.WriteLine(lamp1.isOn); // outputs False

            Console.ReadKey();
        }
    }
}
