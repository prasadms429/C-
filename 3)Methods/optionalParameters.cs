using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RaiseToPower(2)); // 2^2=4
            Console.WriteLine(RaiseToPower(2, 3));  // 2^3=8
            Console.ReadKey();
        }

        static int RaiseToPower(int x, int y = 2)
        {
            int result=1;
            for(int i = 1; i <= y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
