/* Write a boolean expression that checks for given integer if it can be divided (without remainder) 
by 7 and 5 in the same time. */

using System;

class BooleanCheksIntIfDivBy7And5
{
    static void Main()
    {
        Console.WriteLine("Insert Number between {0} and {1}", int.MinValue, int.MaxValue);
        int a = int.Parse(Console.ReadLine());
        bool b = (a % 5 == 0) & (a % 7 == 0);
        if (b == true)
            Console.WriteLine("{0} can be divided by 7 and 5 simultaneously!", a);
        else
            Console.WriteLine("{0} can not be divided by 7 and 5 simultaneously!", a);
    }
}
