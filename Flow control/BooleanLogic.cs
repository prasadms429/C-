using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Higher precedence
            // !            (Not operator)
            // < > <= =>    (Relational operator)
            // == !=        (Equality operator)
            // &&
            // ||
            // Lower precedence

            bool expression;
            expression = 2 > 5 || 4 == 4 && 6 <= 7;

            // 2 > 5 || 4 == 4 && 6 <= 7
            // false || 4 == 4 && 6 <= 7
            // false || 4 == 4 && true
            // false || true && true
            // false || true
            // true

            Console.WriteLine(expression);

            Console.ReadKey();
        }
    }
}
