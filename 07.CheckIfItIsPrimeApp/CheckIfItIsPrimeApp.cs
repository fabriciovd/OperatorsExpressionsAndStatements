using System;
/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
*/


class CheckIfItIsPrimeApp
{
    static void Main()
    {
        Console.Title = "Check If It Is A Prime";
        uint number = uint.Parse(Console.ReadLine());
        bool shure = ((number <= 100) & (number >= 1));

        if (shure == true)
        {
            uint del = 2;
            uint maxdel = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (del <= maxdel))
            {
                if (number % del == 0)
                {
                    prime = false;
                }
                del++;
            }
            Console.WriteLine("Is it Prime? {0}", prime);

        }
        else
        {
            Console.WriteLine("Wrong Number");
        }



    }
}

