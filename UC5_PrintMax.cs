using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGeneric
{
    class UC5_PrintMax<T> where T :IComparable
    {
        public T[] value;
        public UC5_PrintMax(T[] array)
        {
            this.value = array;
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T FindMaxValue()
        {
            T[] sorted = Sort(value);
            return sorted[sorted.Length - 1];
            
        }
    }
}
