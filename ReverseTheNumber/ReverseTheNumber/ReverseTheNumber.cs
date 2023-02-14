using System;
namespace ReverseTheNumber
{
    class ReverseTheNumber
    {
        static void Main(string[] args)
        {
            int Number, Reverse = 0, Rem;
            Console.WriteLine("Enter a Number To Reverse :");
            Number = int.Parse(Console.ReadLine());
            while (Number != 0)
            {
                Rem = Number % 10;
                Reverse = Reverse * 10 + Rem;
                Number /= 10;
            }
            Console.WriteLine("Reversed Number: "+ Reverse);
            Console.ReadLine();
        }
    }
}