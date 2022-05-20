using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversionAndUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int myInt = 3;
            double myDouble = 2.5;

            myDouble = myInt;   //implicit conversion (It take place through without data loss)
            myInt = (int)myDouble;  // Explicit conversion (It take place through with data loss)

            String myString = "5";
            myInt = Convert.ToInt32(myString);

            Console.ReadKey();*/

            // Reading input from user
            char myChar;
            Console.Write("Enter a character:");
            myChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("My character is:" + myChar);
            Console.ReadKey();

            String myString;
            Console.Write("Enter string:");
            myString = Console.ReadLine();
            Console.WriteLine("My String is:" + myString);
            Console.ReadKey();
        }
    }
}
