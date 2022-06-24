using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueVsReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3};  // The int,double and bool are Value type.
            int[] myArray2;

            myArray2 = myArray; // passes reference of myArray to myArray2, that  is it passes addresses of elements of first array to second array.

            Console.WriteLine(myArray2[0]); // outputs 1
            Console.WriteLine(myArray2[1]); // outputs 2
            Console.WriteLine(myArray2[2]); // outputs 3

            myArray2[0] = 7;

            Console.WriteLine(myArray[0]);  // outputs 7

            myArray[0] = 1;

            myArray2 = (int[])myArray.Clone();  // It copies the values of first array to second array, without passing its addresses.
            myArray2[1] = 5;
            Console.WriteLine(myArray[1]);  // outputs 2

            Console.ReadKey();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueVsReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 1, 2, 3 };

            setMethod(myArray1);
            Console.WriteLine(myArray1[0]); //outputs 7

            myArray1[0] = 1;

            setMethod2(myArray1);
            Console.WriteLine(myArray1[0]); //outputs 1

            setMethod3(ref myArray1);
            Console.WriteLine(myArray1[0]); //outputs 0

            Console.ReadKey();

        }
        static void setMethod(int[] myArray2)   //It takes the address of myArray1 elements.
        {
            myArray2[0] = 7;
        }
        static void setMethod2(int[] myArray2)
        {
            myArray2 = new int[3];             //It passes the copies of first array elements to second array.
        }
        static void setMethod3(ref int[] myArray2)
        {
            myArray2=new int[3];                // It references the second array to first array and its values are assigned to zero.
        }
    }
}
