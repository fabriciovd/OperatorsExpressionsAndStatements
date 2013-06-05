/*Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
*/
using System;


class CheckPointXYInCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert X coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("PLease insert Y coordinate:");
        double y = double.Parse(Console.ReadLine());
        double areaxy = 12.5d; //The max AREA of point with x an y from circile can take is  [(a^2)=(R^2)*2)]/4
        bool check = (Math.Abs(x * y)) <= areaxy;
        if (((x == 0) & (Math.Abs(y) > 5) | ((Math.Abs(x) > 5) & (y == 0))))
            Console.WriteLine("The coordinates are not from circle");
        else
            Console.WriteLine((Math.Abs(x * y)) <= areaxy ? "The coordinates are from circle" : "The coordinates are not from circle");

    }
}

