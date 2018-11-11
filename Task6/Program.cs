using System;

namespace Task6
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
            decimal greater = Math.Max(a, b);
            decimal smaller = Math.Min(a, b);
            Console.WriteLine("Greater: " + greater);
            Console.WriteLine("Smaller: " + smaller);

        }
    }
}
