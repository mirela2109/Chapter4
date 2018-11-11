using System;

namespace Task1
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

            Console.Write("c: ");
            string cString = Console.ReadLine();
            int c = int.Parse(cString);

            long sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
