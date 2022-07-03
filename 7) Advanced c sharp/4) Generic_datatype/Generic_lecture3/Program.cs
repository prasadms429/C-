using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class ProgramA
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(10);
            string myString;

            stack.push("Hello");
            stack.push("world");

            myString = stack.pop();

            Stack<int> stack2 = new Stack<int>(10);
            Stack<double> stack3 = new Stack<double>(10);

            Console.ReadKey();
        }
    }
}
