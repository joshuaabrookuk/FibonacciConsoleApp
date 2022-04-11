using System;

namespace FibonacciConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Fibonacci");
            Console.WriteLine("----------");
            Console.WriteLine("How many places would you like to print the Fibonacci sequence?");

            while (!endApp)
            {
                int num = Int32.Parse(Console.ReadLine());

                int i, third, first = 0, second = 1;

                Console.Write(first + " " + second + " ");

                for (i = 2; i < num; ++i)
                {
                    third = first + second;
                    Console.Write(third + " ");
                    first = second;
                    second = third;
                }
                Console.WriteLine("\n");
                Console.Write("Press 'n' and enter to close the app:");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");
            }

        }
    }
}
