/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
 * and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/
using System;


class CheckPointXYInCircleOutOfRectangle
{
    static void Main(string[] args)
    {
        Console.Title = "XY Check fo circle and rectangle";
        Console.WriteLine("Insert X for point A:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert Y for point A:");
        int y = int.Parse(Console.ReadLine());
        bool circhek = (Math.Abs(x * y)) <= 4.5;
        bool recchek = (x >= -1 & x <= 5) & (y <= 1 & y >= -1);
        {
            if ((circhek == true) & (recchek == false))

                Console.WriteLine("Point A is form circle and out of rectangle");
            else
            {
                if ((circhek == true) & (recchek == true))
                    Console.WriteLine("Pint A is from circle and rectangle");
                else
                {
                    if ((circhek == false) & (recchek == true))
                        Console.WriteLine("Point A is out of circle and is in rectangle");
                    else
                        Console.WriteLine("Point A is out of circle and rectangle");
                }
            }
        }
    }
}
