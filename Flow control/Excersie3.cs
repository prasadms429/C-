using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String youLikePizza;
            bool isValid;

            do
            {
                Console.Write("Do you like Pizza? (yes/no):");
                youLikePizza = Console.ReadLine();

                if(youLikePizza == "yes")
                {
                    Console.WriteLine("You like Pizza");
                    isValid = true;
                }
                else if(youLikePizza == "no")
                {
                    Console.WriteLine("You dont like Pizza");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("You didn't entered valid input, please enter valid input");
                    isValid=false;
                    Console.WriteLine();
                }
            }while(isValid==false);

            Console.ReadKey();
        }
    }
}
