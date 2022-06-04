using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNumChoice = 3;
            String doorChoice;

            for(int i = 1; i <= totalNumChoice; i++)
            {
                Console.Write("Enter number between 1-5 to win Prize, This is #"+i+" attempt: ");
                doorChoice = Console.ReadLine();

                switch (doorChoice)
                {
                    case "1":
                        Console.WriteLine("You won baloon");
                        break;
                    case "2":
                        Console.WriteLine("You won bycycle");
                        break ;
                    case "3":
                        Console.WriteLine("You won motorcycle");
                        break;
                    default:
                        Console.WriteLine("Its not a valid input, please enter valid input");
                        break;

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
