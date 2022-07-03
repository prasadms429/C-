using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_lecture4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "a";
            string string2 = "b";

            int int1 = 1;
            int int2 = 2;

            swap<string>(ref string1, ref string2);
            Console.WriteLine(string1);
            Console.WriteLine(string2);

            swap<int>(ref int1, ref int2);
            Console.WriteLine(int1);
            Console.WriteLine(int2);

            Console.ReadKey();

        }

        static void swap<T>(ref T item1, ref T item2)
        {
            T tempItem;
            tempItem=item1;
            item1 = item2;
            item2=tempItem;
        }

    }
}
