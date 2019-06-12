using System;
using System.Collections.Generic;

namespace Working_with_Control_Flow_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            Exercise3();
        }

        private static void Exercise3()
        {
            /* Write a program and ask the user to enter a number.
             Compute the factorial of the number and print it on the console.
             For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
             and display it as 5! = 120.
             */

            Console.WriteLine("Enter a Number");

            var originalUserInput = Convert.ToInt32(Console.ReadLine());
            var userInput = originalUserInput;
            var factorial = 1;

            for (int i = 1; i <= userInput; i++)
            {
                factorial *= i;
            }
            
            Console.WriteLine("{0}! = {1}", originalUserInput, factorial);
        }

        private static void Exercise2()
        {
            /*Write a program and continuously ask the user to enter a number or "ok" to exit.
             Calculate the sum of all the previously entered numbers and display it on the console.
             */

            var isUserDone = false;
            var sum = 0;

            while (!isUserDone)
            {
                Console.WriteLine("Enter a new number, or type \"ok\" to exit" );
                var userInput = Console.ReadLine();
                if (userInput == "ok")
                {
                    isUserDone = true;
                    break;
                }
                sum += Convert.ToInt32(userInput);
            }

            Console.WriteLine("Your sum is: " + sum);
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
