/*Write an expression that calculates rectangle’s area by given width and height.*/
using System;


class RectangleCalculator
{
    static void Main()
    {
        Console.Title = "Rectangle Calculator";
        Console.WriteLine("Wellcome, I am a rectangle calculator:");
        Console.WriteLine("Please, insert side A:");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please, insert side B:");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.WriteLine("{0} units * {1} units =" + " " + (width * height) + " square units", width, height);

    }
}
