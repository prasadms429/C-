using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueVsReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3};  // The int,double and bool are Value type.
            int[] myArray2;

            myArray2 = myArray; // passes reference of myArray to myArray2, that  is it passes addresses of elements of first array to second array.

            Console.WriteLine(myArray2[0]); // outputs 1
            Console.WriteLine(myArray2[1]); // outputs 2
            Console.WriteLine(myArray2[2]); // outputs 3

            myArray2[0] = 7;

            Console.WriteLine(myArray[0]);  // outputs 7

            myArray[0] = 1;

            myArray2 = (int[])myArray.Clone();  // It copies the values of first array to second array, without passing its addresses.
            myArray2[1] = 5;
            Console.WriteLine(myArray[1]);  // outputs 2

            Console.ReadKey();
        }
    }
}
