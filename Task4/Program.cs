using System;

namespace Task4
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
            double b = double.Parse(bString);
            Console.Write("c: ");
            string cString = Console.ReadLine();
            double c = double.Parse(cString);
            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}",
                a, b, c);

        }
    }
}
