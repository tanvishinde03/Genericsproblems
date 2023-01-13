﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsproblems
{
    internal class GenericsFindMax<T> where T : IComparable
    {
        public static void FindMaxValue(T first, T second, T third)
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

























