using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGeneric
{
    class UC2_FindMaxFloat
    {
        public void FindMax(double  a,double  b, double c)
        {
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
            {
                Console.WriteLine(a + " is maximum");

            }
            if ((b.CompareTo(c) > 0) && (b.CompareTo(a) > 0))
            {
                Console.WriteLine(b + " is maximum");

            }
            if ((c.CompareTo(a) > 0) && (c.CompareTo(b) > 0))
            {
                Console.WriteLine(c + " is maximum");
            }
            else
                Console.WriteLine("may be some have same value plz check input again.");

        }
    }
}
