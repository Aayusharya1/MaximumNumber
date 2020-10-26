using System;

namespace MaximumNumberGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int max = FindMaximum.FindMaximumInt(3, 5, 6);
            Console.WriteLine("Maximum number is " + max);

            string max1 = FindMaximum.MaximumStringNumber("Aayush", "Ayush", "Aush");
            Console.WriteLine("Max String is " + max1);
        }
    }
}
