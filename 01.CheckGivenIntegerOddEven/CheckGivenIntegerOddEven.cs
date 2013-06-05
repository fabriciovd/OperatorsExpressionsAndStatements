/*Write an expression that checks if given integer is odd or even.*/

using System;


    class CheckGivenIntegerOddEven
    {
        static void Main()
        {
            Console.Title = "Check Given Integer for Odd or Even";
            //First version
            Console.WriteLine("Please Insert number from {0} to {1}:",int.MinValue,int.MaxValue);
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("It is even!");//if it is true
            else
                Console.WriteLine("It is odd!");//if it is false
            //Second version
            Console.WriteLine(new string('-',79));
            Console.WriteLine("Please Insert Number from {0} to {1}", int.MinValue,int.MaxValue);
            int b = int.Parse(Console.ReadLine());
            bool c = (b % 2 == 0);
                if (c == true)
                    Console.WriteLine("{0} is even!",b);
                else
                    Console.WriteLine("{0} is odd!",b);
        }
    }

