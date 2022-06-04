using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returningPassingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = AddTwoNum(5, 3);   // Here the value passed to function are called arguments and that are 5,3.
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static int AddTwoNum(int x,int y) // Here the value stores the data that is passed in is called parameters and that are x and y.
        {
            int z = x + y;
            return z;
        }
    }
}
