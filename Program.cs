using System;

namespace FindMaxUsingGeneric
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             UC1_Find_Max Check2 = new UC1_Find_Max();
             Check2.checkMax(3, 5, 15);
            */


            /* UC3_FindMaxString Check1 = new UC3_FindMaxString();
             Check1.FindMax("apple", "peach", "banana");*/


            /* UC4_Refactor_One_Method Check = new UC4_Refactor_One_Method();
             Check.FindMax(78, 785, 78);
             Check.FindMax(4.645, 45.6544, 48.984);
             Check.FindMax<string>("apple", "peach", "banana");*/

            //refector 2
            /* GenricMaximum<double> check = new GenricMaximum<double>(4.645, 45.6544, 48.984);
             Console.WriteLine(check.testMaximum());
 */
            // for UC5
            int[] intArray = { 12, 5457, 45, 687, 6554, 6233, 487, 4622 };
            UC5_PrintMax<int> check = new UC5_PrintMax<int>(intArray);
            Console.WriteLine("Maximum is :" + check.FindMaxValue());


        }
    }
}
