﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsproblems
{

    public class FindMaximum
    {
        public static void FindMaxValue(int first, int second, int third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is Maximum", first);
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is  Maximum", second);
            }
            else if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine("{0} is Maximum", third);
            }
            else
                Console.WriteLine("All number are equal");
        }
        public static void FindMaxValue(float first, float second, float third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is Maximum", first);
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is  Maximum", second);
            }
            else if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine("{0} is Maximum", third);
            }
            else
                Console.WriteLine("All number are equal");
        }
        public static void FindMaxValue(string first, string second, string third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is Maximum", first);
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is  Maximum", second);
            }
            else if (third.CompareTo(first) >= 0 && third.CompareTo(second) >= 0)
            {
                Console.WriteLine("{0} is Maximum", third);
            }
            else
                Console.WriteLine("All number are equal");
        }

    }
}



























