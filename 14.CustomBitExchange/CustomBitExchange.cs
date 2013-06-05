/*Write a program that exchanges bits {p, p+1, …, p+k-1) with bits 
 * {q, q+1, …, q+k-1} of given 32-bit unsigned integer.*/
using System;


class CustomBitExchange
{
    static void Main()
    {
        Console.Title = "Custom bit exchanger";
        Console.WriteLine("Please, insert only positive number up to {0}", uint.MaxValue);
        uint n = uint.Parse(Console.ReadLine());
        //uint n = 4294901760; /*Number for test*/
        Console.WriteLine("The number to be converted is {0}", n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Insert first group bit position:");
        uint p = uint.Parse(Console.ReadLine());
        Console.WriteLine("Now insert second group bit position:");
        uint q = uint.Parse(Console.ReadLine());
        Console.WriteLine("And now insert how many bits you want to exchange:");
        uint k = uint.Parse(Console.ReadLine());
        Console.WriteLine("The number to be converted is {0}\n", n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("");
        for (int x = (int)p, y = (int)q; x <= p + k - 1; x++, y++)
        {
            uint mask = (uint)(1 << x);
            uint xbit = (uint)(n & mask) >> x;
            mask = (uint)(1 << y);
            uint ybit = (uint)(n & mask) >> y;
            if (xbit == 0)
            {
                mask = (uint)(~(1 << y));
                n = (uint)n & (uint)mask;
            }
            else
            {
                mask = (uint)(1 << y);
                n = (uint)n | (uint)mask;
            }
            if (ybit == 0)
            {
                mask = (uint)(~(1 << x));
                n = (uint)n & (uint)mask;
            }
            else
            {
                mask = (uint)(1 << x);
                n = (uint)n | (uint)mask;
            }
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(64, '0'));
        }
        Console.WriteLine("\nThe new number is:\n {0}", n);
    }
}