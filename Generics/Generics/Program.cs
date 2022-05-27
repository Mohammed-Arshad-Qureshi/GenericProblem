using System;

namespace Generics
{
    class Program
    {
        public static void toPrint(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("___________________________\n");
        }
        public static void toPrint(double[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("___________________________\n");
        }
        public static void toPrint(string[] inputArray)
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
            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(stringArray);
            Console.ReadLine();
        }
    }
}
