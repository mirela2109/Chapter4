using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r: ");
            string rString = Console.ReadLine();
            int r = int.Parse(rString);
            double P = 2 * r * Math.PI;
            double S = r * r * Math.PI;
            Console.WriteLine("P: "+ P);
            Console.WriteLine("S: "+S);
        }
    }
}
