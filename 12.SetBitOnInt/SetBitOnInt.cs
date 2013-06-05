/*We are given integer number n, value v (v=0 or 1) and a position p. 
Write a sequence of operators that modifies n to hold the value v at the position p 
from the binary representation of n.
Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
n = 5 (00000101), p=2, v=0 -> 1 (00000001)*/
using System;


class SetBitOnInt
{
    static void Main(string[] args)
    {
        Console.Title = "Set a bit of number";
        Console.WriteLine("Insert Number to give it a bit change:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert value only 0 or 1 for the bit");
        int value = int.Parse(Console.ReadLine());
        bool check = ((value == 0) | (value == 1));
        {
            if (check == false)
                Console.WriteLine("Wrong value input");
            else
            {
                if (value == 1)
                {
                    Console.WriteLine("Insert position for the bit:");
                    int positiona = int.Parse(Console.ReadLine());
                    int maska = 1 << positiona;
                    int resulta = number | maska;
                    Console.WriteLine("The result it {0}:", resulta);
                }
                else
                {
                    Console.WriteLine("Insert position for the bit:");
                    int positionb = int.Parse(Console.ReadLine());
                    int maskb = ~(1 << positionb);
                    int resultb = number & maskb;
                    Console.WriteLine("The result it {0}:", resultb);
                }
            }
        }



    }
}