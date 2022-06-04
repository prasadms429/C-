using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name is:");
            SayHello(Console.ReadLine());

            Console.Write("Enter another name:");
            SayHello(Console.ReadLine());

            Console.Write("Enter third name:");
            SayHello(Console.ReadLine(), true);

            Console.ReadKey();
        }
        static void SayHello(String name,bool askHowAreyou = false)
        {
            Console.WriteLine("Hello "+name+" !");
            if (askHowAreyou)
            {
                Console.WriteLine("How are you ?");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
