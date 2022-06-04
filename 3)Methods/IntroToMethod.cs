using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             returnType Name (parameters)
            {
                //do this
            }
             */
           
            Console.WriteLine("You started learning Programming");
            PrintCongrats();    // By using methods we can define once and reuse it again and again.
            Console.WriteLine("You are doing well");
            PrintCongrats();
            Console.WriteLine("You are going to be rich");
            PrintCongrats();

            Console.ReadKey();
        }
        static void PrintCongrats()
        {
            Console.WriteLine("Congratulations !!!");   // If we want to make change we can change (Method) in that one specific part, donot need to change in all parts of program.
        }
    }
}
