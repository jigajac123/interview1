using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] list1 = new[] { 1, 2, 3, 4,5};

            int[] list2 = new[] {3,4, 5, 6,7 };

            //a.Common elements in both lists


            int[] list3 = list1.Intersect(list2).ToArray();

            Console.WriteLine(string.Join(",",list3));

            //b.Unique elements in list1 not found in list2

            int[] list4 = list1.Except(list3).ToArray();

            Console.WriteLine(string.Join(",", list4));


            //c.Unique elements in list2 not found in list1

            int[] list5 = list2.Except(list3).ToArray();

            Console.WriteLine(string.Join(",", list5));

        }
    }
}