using System;

namespace MaximumNumberGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int max = FindMaximum.FindMaximumInt(3, 5, 5);
            Console.WriteLine("Maximum number is " + max);
        }
    }
}
