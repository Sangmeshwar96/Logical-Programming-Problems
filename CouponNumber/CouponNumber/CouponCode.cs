using System;

namespace CouponNumber
{
    public class CouponCode
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter length of coupons");
            int number = int.Parse(Console.ReadLine());
            string coupons = string.Empty;
            while (number > 0)
            {
                int random = new Random().Next(1, 123);
                coupons += (char)random;
                number--;
            }
            Console.WriteLine("Your coupon number is " + coupons);
            Console.ReadLine();
        }
    }
}