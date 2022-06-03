using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String yourName;
            int yourAge;
            String friendName;
            int friendAge;

            Console.Write("Enter your name:");
            yourName = Console.ReadLine();  // In this it reads as string and store to string variable
            Console.Write("Enter your age:");
            yourAge=Convert.ToInt32(Console.ReadLine()); // In this it reads as string and convert it into integer by using "Convert.ToInt32" to store in integer variable.
            Console.WriteLine("Your name is " + yourName + " and you are " + yourAge + " years old");
            Console.WriteLine();

            Console.Write("Enter friend name:");
            friendName = Console.ReadLine();
            Console.Write("Enter friend age:");
            friendAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("friend name is " + friendName + " and you are " + friendAge + " years old");
            Console.WriteLine() ;

            Console.WriteLine("There are " + (yourAge + friendAge) + " years between two"); // while concatenation it convets integer variable to string, to display.

            Console.ReadKey();


        }
    }
}
