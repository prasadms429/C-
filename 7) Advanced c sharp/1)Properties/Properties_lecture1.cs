using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Myclass
    {
        //private int _myInteger;   // properties is the hybrid combination of fields and methods. It makes code easy to read and provides data integrity as encapsulation.

        //public int MyInteger
        //{
        //    get
        //    {
        //        return _myInteger;
        //    }
        //    set
        //    {
        //        _myInteger = value;
        //    }
        //}

        public int MyInteger { get; set; }  // Automatic property in simple code.
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass MyObject = new Myclass();
            MyObject.MyInteger = 5; // calls set accesor
            Console.WriteLine(MyObject.MyInteger);  // calls get accesor

            Console.ReadKey();
        }
    }
}
