using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack<T> // T is generic datatype
    {
        private T[] array;
        private int current_index;

        public Stack(int size)
        {
            array = new T[size];
            current_index = 0;
        }

        public void push(T item)
        {
            array[current_index]=item;
            current_index++;
        }

        public T pop()
        {
            current_index--;
            return array[current_index];
        }
    }
}
