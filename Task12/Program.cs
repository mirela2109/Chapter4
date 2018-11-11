using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int n = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(n);
            for (int i = 3; i <= 100; i++)
            {
                a = b;
                b = n;
                n = a + b;
                Console.WriteLine(n);

            }
        }
    }
}
