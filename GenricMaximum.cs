using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGeneric
{
    class GenricMaximum<T> where T : IComparable
    {
        public T a, b, c;

        public GenricMaximum(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static T FindMax(T a, T b,T c)
        {

            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0) ||
                (a.CompareTo(b) >= 0) && (a.CompareTo(c) > 0) ||
                (a.CompareTo(b) > 0) && (a.CompareTo(c) >= 0))
            {
                return a;

            }
            if ((b.CompareTo(c) > 0) && (b.CompareTo(a) > 0) ||
                (b.CompareTo(c) >= 0) && (b.CompareTo(a) > 0) ||
                (b.CompareTo(c) > 0) && (b.CompareTo(a) >= 0))
            {
                return b;

            }
            if ((c.CompareTo(a) > 0) && (c.CompareTo(b) > 0) ||
                (c.CompareTo(a) >= 0) && (c.CompareTo(b) > 0) ||
                (c.CompareTo(a) > 0) && (c.CompareTo(b) >= 0))
            {
                return c;
            }
            return default;
        }

        public T testMaximum()
        {
            T maximum = GenricMaximum<T>.FindMax( this.a, this.b, this.c);
            return maximum;
        }
    }
}
