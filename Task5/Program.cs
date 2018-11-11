using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            string aString = Console.ReadLine();
            int a = int.Parse(aString);
            Console.Write("b: ");
            string bString = Console.ReadLine();
            int b = int.Parse(bString);

            int c = (b / 5) - (a / 5);
            if (a % 5 == 0)
            {
                c++;
            }
            Console.WriteLine(c);

        }
    }
}
