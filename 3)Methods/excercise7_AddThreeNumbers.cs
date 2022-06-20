using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, sum;

            Console.Write("Enter an interger:");
            x=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second integer:");
            y=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third integer:");
            z=Convert.ToInt32(Console.ReadLine());

            sum=AddThreeInteger(x,y,z);
            Console.WriteLine("The sum of three integers are: " + sum);

            Console.WriteLine();

            Console.Write("Enter an interger:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second integer:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third integer:");
            z = Convert.ToInt32(Console.ReadLine());

            sum = AddThreeInteger(x, y, z, ref sum);
            Console.WriteLine("The sum of three integers are: " + sum);

            Console.ReadKey();
        }

        static int AddThreeInteger(int x, int y, int z)
        {
            return x + y + z;
        }
        static int AddThreeInteger(int x,int y,int z, ref int sum)
        {
            sum = x + y + z;
            return sum;
        }
    }
}
