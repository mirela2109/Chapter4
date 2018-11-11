using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            string nString = Console.ReadLine();
            int n = int.Parse(nString);
            int currentNum = 0;
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                nString = Console.ReadLine();
                currentNum = int.Parse(nString);
                sum = sum + currentNum;
            }
            Console.WriteLine(sum);

        }
    }
}
