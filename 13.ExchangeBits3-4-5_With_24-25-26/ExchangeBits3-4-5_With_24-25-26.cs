/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/
using System;

class ExchangeThreeBits
{
    static void Main()
    {
        Console.Title = " Exchange three bits";
        uint number = 4294901760;
        //Console.WriteLine("Insert positive number from 0 to {0}",uint.MaxValue);
        //uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Number for exchange is {0} \n", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        for (int p = 5; p > 2; p--)
        {
            int q = 31 - p;
            {
                int mask = 1 << p;
                int pbit = (int)(number & mask) >> p;
                mask = 1 << q;
                int qbit = (int)(number & mask) >> q;
                if (pbit == 0)
                {
                    mask = ~(1 << q);
                    number = (uint)number & (uint)mask;
                }
                else
                {
                    mask = 1 << q;
                    number = (uint)number | (uint)mask;
                }
                if (qbit == 0)
                {
                    mask = ~(1 << p);
                    number = (uint)number & (uint)mask;
                }
                else
                {
                    mask = 1 << p;
                    number = (uint)number | (uint)mask;
                }
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
        Console.WriteLine("\n");

    }
}
