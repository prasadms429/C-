using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IMyInterface  // interfaces allow different objects to expose COMMON functionality and can implement different data type objects using same interface. 
                            // It is better alternative to implement multiple inheritances .
    {
        void SomeMethod();
        int AnotherMethod(string someString);
    }

    class Myclass : IMyInterface
    {
        private int x, y;
        public void MyMethod()
        {
            // method code
        }
        public void SomeMethod()
        {
            // method code
        }
        public int AnotherMethod(string someString)
        {
            return 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass MyClassObject = new Myclass();
            IMyInterface MyInerface = MyClassObject;

            MyInerface.SomeMethod();
            MyInerface.AnotherMethod("hello");

        }
    }
}
