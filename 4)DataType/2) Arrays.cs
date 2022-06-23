using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNumberArray = { 5, 4, 7 };
            int[] myNumberArray2 = new int[3];  // It creates an empty array integers with size of 3 and intializes its all values to zero. If its datatype is bool then its value would be 'false' or for other datatypes it is 'NULL'.

            Console.WriteLine(myNumberArray[1]);
            myNumberArray[2] = 6;

            for(int index=0;index<myNumberArray.Length;index++)
            {
                Console.WriteLine(myNumberArray[index]);
            }

            foreach(int number in myNumberArray)  // In 'for each' loop we can read only and we cannot make modification to data. To make modification, we need to use regular 'for' loop
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
