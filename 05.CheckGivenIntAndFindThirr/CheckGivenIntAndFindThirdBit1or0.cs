/*Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
*/
using System;


class CheckGivenIntAndFindThirdBit1or0
{
    static void Main()
    {
        Console.Title = ("Check for 1 in third digit");
        int a = 2;
        Console.WriteLine("Insert number form {0} to {1}", int.MinValue, int.MaxValue);
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << a;
        int bandmask = b & mask;
        int tbit = bandmask >> a;
        bool c = tbit == 1;
        Console.WriteLine("Bool check: {0}",c);
        Console.WriteLine(b + " is " + (Convert.ToString(b, 2)).PadLeft(32, '0') + " bin representation");
        Console.WriteLine((Convert.ToString(tbit, 2)) + " is the third bit in {0}", b);
    }
}
