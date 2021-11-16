using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGeneric
{
    class UC3_FindMaxString
    {
        public void FindMax(string a, string b, string c)
        {

           if( (a.CompareTo(b)>0) && (a.CompareTo(c)>0)) 
            {
                Console.WriteLine(a + " is maximum");

            }
            else if ((b.CompareTo(c) > 0) && (b.CompareTo(a) > 0))
            {
                Console.WriteLine(b + " is maximum");

            }
            else if ((c.CompareTo(a) > 0) && (c.CompareTo(b) > 0))
            {
                Console.WriteLine(c + " is maximum");
            }
            else
                Console.WriteLine("may be some input have same value plz check input again.");

        }
    }
}
