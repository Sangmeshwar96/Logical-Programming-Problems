using System;

namespace PerfectNumber
{
    class PerfectNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine($"The divisors for "+n+" are :" );
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine(n +" = "+ sum);
            if (n == sum)
            {
                Console.WriteLine(n +" is a perfect number");
            }
            else
            {
                Console.WriteLine(n+" is not a perfect number");
            }
            Console.ReadLine();
        }
    }
}