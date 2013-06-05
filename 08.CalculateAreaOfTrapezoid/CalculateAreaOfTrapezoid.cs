/*Write an expression that calculates trapezoid's area by given sides a and b and height h. Area=(a+b/2)*h
*/
using System;


class CalculateAreaOfTrapezoid
{
    static void Main()
    {
        Console.Title = "Trapezoid calculator";
        Console.WriteLine("Please, insert Side A, only positive number: max {0}",uint.MaxValue);
        uint a = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please, insert Side B, only positive number: max {0}", uint.MaxValue);
        uint b = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please, insert Height H, only positive number: max {0}", uint.MaxValue);
        uint h = uint.Parse(Console.ReadLine());
        uint area = ((a + b) / 2) * h;
        Console.WriteLine("Calculated area = {0} sqare units",area);
    }
}
