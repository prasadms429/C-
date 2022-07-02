using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] myArray = { 1, 2, 3 };
            int mySelection;
            bool error;

            do
            {
                error = false;
                try               // Exceptions causes programs to crash, by using this we can avoid program crashing.
                {
                    Console.WriteLine("Enter the array index of the element you wish to view: ");
                    mySelection = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(myArray[mySelection]);
                }
                catch(Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message + " Please try again.");
                }

                }while(error);
            
            Console.ReadKey();*/

            int selection;

            Console.Write("Enter an integer between 1 and 100:");

            try
            {
                selection=Int32.Parse(Console.ReadLine());
                if(selection<0 || selection>100)
                {
                    throw new Exception($"Invalid input. {selection} is not between 1 and 100");
                }
                Console.WriteLine();
                Console.WriteLine($"The entered integer is {selection}");
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
