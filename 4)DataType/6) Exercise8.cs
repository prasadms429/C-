using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            string[] groceries = new string[arraySize];
            string substring;
            int count = 0;

            for(int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter the grocery item {i+1}:");
                groceries[i] = Console.ReadLine();
            }

            Console.Write("\nEnter substring to find: ");
            substring=Console.ReadLine();

            foreach(string groceryItem in groceries)
            {
                if(groceryItem.Contains(substring))
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.Write($"\nThere is {count} element that contains substring \"{substring}\"");
            }
            else
            {
                Console.Write($"\nThere are {count} element that contains substring \"{substring}\"");
            }

            Console.ReadKey();
        }
    }
}
