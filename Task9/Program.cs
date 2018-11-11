using System;

namespace Task9
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

            double D = (b * b) - (4 * a * c);
            double root1;
            double root2;
            if (D > 0)
            {
                root1 = (-b + Math.Sqrt(D)) / (2 * a);
                root2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Two real roots.");
                Console.WriteLine(root1);
                Console.WriteLine(root2);
            }
            else if (D == 0)
            {
                root1 = root2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("One real root.");
                Console.WriteLine(root1);
            }
            else
            {
                Console.WriteLine("No real roots.");
            }

        }
    }
}
