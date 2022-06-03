using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String gucamolResponse;
            bool gucamolOnSale;
            double moneyInYourPocket;

            Console.Write("Is Gucamol on sale? (yes/no):");
            gucamolResponse = Console.ReadLine();

            if (gucamolResponse == "yes")
            {
                gucamolOnSale = true;
            }
            else
            {
                gucamolOnSale = false;
            }

            Console.Write("Enter money in your Pocket:");
            moneyInYourPocket = Convert.ToDouble(Console.ReadLine());

            if ((gucamolOnSale && moneyInYourPocket >= 10)||moneyInYourPocket>=100)
            {
                Console.WriteLine("Let's go for shopping");
            }
            else
            {
                Console.WriteLine("Let's stay home");
            }

            Console.ReadKey();
        }
    }
}
