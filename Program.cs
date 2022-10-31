using System;
namespace PrimeNumber
{
    class Ex
    {
        public static void Main(string[] args)
        {
            int n, i, a = 0, drp = 0;
            Console.Write(" N = ");
            n = int.Parse(Console.ReadLine());
            a = n / 2;
            for (i = 2; i <= a; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Non Premier");
                    drp = 1;
                    break;
                }
            }
        }
    }
}