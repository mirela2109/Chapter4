using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            double sum = 1.0;
            for (int i = 2; i <= n; i++)
            {
                sum = sum + (1.0 / i);
            }
            Console.WriteLine("{0:F3}", sum);

        }
    }
}
