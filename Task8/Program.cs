using System;

namespace Task8
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

            Console.Write("c: ");
            string cString = Console.ReadLine();
            int c = int.Parse(cString);
            greater = Math.Max(c, greater);

            Console.Write("d: ");
            string dString = Console.ReadLine();
            int d = int.Parse(dString);
            greater = Math.Max(d, greater);

            Console.Write("e: ");
            string eString = Console.ReadLine();
            int e = int.Parse(eString);
            greater = Math.Max(e, greater);

            Console.WriteLine("Greater: " + greater);

        }
    }
}
