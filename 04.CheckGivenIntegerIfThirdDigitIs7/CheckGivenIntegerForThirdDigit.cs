using System;
/*Write an expression that checks for given integer if its third digit (right-to-left) 
  is 7. E. g. 1732 -> true.*/



class CheckGivenInteger
{
    static void Main()
    {
        {
            Console.Title = "Is Third Digit is 7";
            /*first automatic for 1732*/
            Console.WriteLine("Automatic checked number: 1732");
            int a = 1732;
            int b = a % 1000;
            int c = b / 100;
            bool d = (c == 7);
            if (d == true)
                Console.WriteLine("The Third digit is 7");
            else
                Console.WriteLine("The Third digit is not 7");
            Console.WriteLine("");
        }
        {
            /*second version with readline*/
            Console.WriteLine("Please, enter a new number:");
            int e = int.Parse(Console.ReadLine());
            int f = e % 1000;
            int g = f / 100;
            bool h = (g == 7);
            if (h == true)
                Console.WriteLine("The Third digit form Right to Left is 7");
            else
                Console.WriteLine("The Third digit form Right to Left is not 7 it is {0}", g);
            Console.WriteLine("");
        }
    }
}

