using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Car1=new Car();

            Car1.Color = "Red";
            Car1.Brand = "Toyota";

            Console.WriteLine(Car1.Color);
            Console.WriteLine(Car1.Brand);

            Console.ReadKey();
        }
    }
}
