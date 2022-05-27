using System;

namespace Generics
{
    class Program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("___________________________\n");
        }
       
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4, 4.5 };
            string[] stringArray = { "H", "E", "L", "l", "O" };
            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<string>(stringArray);
            Console.ReadLine();
        }
    }
}
