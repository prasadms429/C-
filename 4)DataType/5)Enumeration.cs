using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    internal class Program
    {
        enum DayOfWeek : byte { Sunday,Monday,Tuesday,Wednesday=5,Thursday,Friday}; // To define user defined data type we use enumeration.
        static void Main(string[] args)
        {
            DayOfWeek currentDay;

            currentDay = DayOfWeek.Teusday; // Gives compiler error

            currentDay = DayOfWeek.Tuesday;
            Console.WriteLine(currentDay);  // outputs Tuesday

            Console.WriteLine((int)currentDay); // outputs 2

            Console.ReadLine();
        }
    }
}
