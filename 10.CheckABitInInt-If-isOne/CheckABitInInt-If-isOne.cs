/*Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
*/
using System;


class CheckABitInIntIfisOne
{
    static void Main()
    {
        Console.Title="CheckABitInInt-If-isOne";
        Console.WriteLine("Insert a number:");
        int number=int.Parse(Console.ReadLine());
        Console.WriteLine("Insert digit to check if it is 1 or 0 from number {0}",number);
        int digit=int.Parse(Console.ReadLine());
        int mask=(1<<digit);
        int numberAmask=number&mask;
        int bit=numberAmask>>digit;
        bool cheknum=(bit==1);
        Console.WriteLine(cheknum);
    }
}

