using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGeneric
{
    class UC4_Refactor_One_Method
    {
        public void FindMax<T>(T a, T b, T c)
        {

            if ((Comparer<T>.Default.Compare(a, b) > 0) && (Comparer<T>.Default.Compare(a, c) > 0))
            {
                Console.WriteLine(a + " is maximum");

            }
            else if ((Comparer<T>.Default.Compare(b, a) > 0) && (Comparer<T>.Default.Compare(b, c) > 0))
            {  
                Console.WriteLine(b + " is maximum");

            }
            else if ((Comparer<T>.Default.Compare(c, a) > 0) && (Comparer<T>.Default.Compare(c, b) > 0))
            {
                Console.WriteLine(c + " is maximum");
            }
            else
                Console.WriteLine("may be some input have same value plz check input again.");
        }


        
        }
    }
