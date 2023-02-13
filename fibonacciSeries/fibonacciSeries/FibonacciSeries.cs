namespace fibonacciSeries
{
    public static class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c=0, i, number;
            Console.WriteLine("Enter The Number of Element ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(a+" "+b+ " ");
            for(i=2;i<number;i++)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;  
            }
            Console.ReadLine();
        }
    }
}