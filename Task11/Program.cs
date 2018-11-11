using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
