using System;
using System.Collections.Generic;

namespace Working_with_Control_Flow_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        private static void Exercise1()
        {
            /* Write a program to count how many numbers between 1 and 100
             are divisible by 3 with no remainder.
             Display the count on the console.
             */

            //added func displays which numbers are divisible by 3
            var nonDivisibleNumbers = new List<int>();
            var totalNonDivisiable = 0;

            for (int i = 1; i < 100; i++)
            {
                if ((i%3) > 0)
                {
                    nonDivisibleNumbers.Add(i);
                    totalNonDivisiable++;
                }
            }

            Console.WriteLine(@"Total Non Divisible:" + totalNonDivisiable);
            foreach (var nonDivisibleNumber in nonDivisibleNumbers)
            {
                Console.Write(nonDivisibleNumber + ",");
            }
        }
    }
}
