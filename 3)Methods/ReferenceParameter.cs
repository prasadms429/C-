using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenceParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            ChangeNum(out x);       // If we dont initalize out, then it passes only copy of arguments, if we intialize it passes the adress of that arguement that is stored.
                                    // We can use keyword "ref" or "out", both are same except ref variable must be intialized before using.
            Console.WriteLine(x);   // now it prints 5, If it is not declared out or ref in function then it returns 0;

            Console.ReadKey();


        }
        static int ChangeNum(out int y)
        {
            y = 0;
            return y;
        }
    }
}
