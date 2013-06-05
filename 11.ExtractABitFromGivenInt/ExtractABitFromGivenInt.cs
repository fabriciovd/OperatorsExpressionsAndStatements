/*Write an expression that extracts from a given integer i the value of a given bit number b. 
 * Example: i=5; b=2 -> value=1.
*/
using System;


class ExtractABitFromGivenInt
{
    static void Main()
    {
        Console.Title = "Bit Extractor";
        Console.WriteLine("Insert number for extraction: from {0} to {1}",int.MinValue,int.MaxValue);
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert digit to extract:");
        int digit=int.Parse(Console.ReadLine());
        int mask = 1 << digit;
        int numandmask = number & mask;
        int bit = numandmask >> digit;
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0') + " : Bit representation of inserted number {0}", number);
        Console.WriteLine("The {0} digit from 0 (right to left) is: {1}", digit, bit);

    }
}

