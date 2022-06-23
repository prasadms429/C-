using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is \"Prasad M S\"");   // It will print "Prasad M S" with cotated " "
            Console.WriteLine("The new path is C:\\Users\\directory");    // To print single "\", we use this "\\"
            Console.WriteLine("Typing backlash n in a string\n will cause a line break");
            
            int numApples = 7;
            int numBananas = 3;

            Console.WriteLine("There are " + numApples + " apples and " + numBananas + " bananas"); // string concatenation
            Console.WriteLine("There are {0} apples and {1} bananas", numApples, numApples); // string formatting
            Console.WriteLine($"There are {numApples} apples and {numBananas} bananas"); // string interpolation
            Console.WriteLine($"There are {numApples + numBananas} pieces of fruits");  // string interpolation
            
            
            
            string myString;

            myString = "abc";
            Console.WriteLine(myString.Length); // prints 3

            myString = "I'm Learning C#";
            Console.WriteLine(myString.ToUpper());  // outputs "I'M LEARNING C#"
            Console.WriteLine(myString.ToLower());  // outputs "i'm learning c#"

            myString = "This is fun!";
            Console.WriteLine(myString.Contains("is")); // outputs "true"
            Console.WriteLine(myString.Contains("by")); // outputs "false"

            myString = "This is fun!";
            Console.WriteLine(myString.IndexOf("i"));   // outputs "2"
            Console.WriteLine(myString.IndexOf("j"));   // outputs "-1"

            myString = "This is fun!";
            Console.WriteLine(myString.Substring(5));   // outpus "is fun!"
            Console.WriteLine(myString.Substring(5, 2)); // outputs "is"

            myString = "This is fun!";
            Console.WriteLine(myString.Remove(5));  // oupts "This "
            Console.WriteLine(myString.Remove(5, 2));   // outputs "This  fun!"

            myString = "This is fun!";
            Console.WriteLine(myString.Replace("fun", "awesome")); // ouputs "This is awesome"

            int myInt = 5;
            double myDouble = 5.4445667777;
            bool myBool = false;

            myString = myInt.ToString();
            myString=myDouble.ToString("F");    // "5.45" will be stored in myString
            myString=myBool.ToString();

            Console.ReadLine();
        }
    }
}
