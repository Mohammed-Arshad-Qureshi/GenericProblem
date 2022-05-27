using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            GenericMax<int> integerVal = new GenericMax<int>(1, 2, 3);
            GenericMax<double> doubleVal = new GenericMax<double>(1.1, 1.2, 1.3);
            GenericMax<string> stringVal = new GenericMax<string>("1", "2", "3");

            int val1 = integerVal.MaxMethod();
            double val2 = doubleVal.MaxMethod();
            string val3 = stringVal.MaxMethod();
            Console.WriteLine("Inter Max value   :  " + val1);
            Console.WriteLine("double Max value  :  " + val2);
            Console.WriteLine("string Max value  :  " + val3);
            Console.ReadLine();

        }
    }
}
