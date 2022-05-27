using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            GenericMax<int> integerVal = new GenericMax<int>();
            GenericMax<double> doubleVal = new GenericMax<double>();
            GenericMax<string> stringVal = new GenericMax<string>();

            int val1 = integerVal.MaximumAnyNumber(1, 2, 3);
            double val2 = doubleVal.MaximumAnyNumber(1.1, 1.2, 1.3);
            string val3 = stringVal.MaximumAnyNumber("1", "2", "3");
            Console.WriteLine("Inter Max value   :  " + val1);
            Console.WriteLine("double Max value  :  " + val2);
            Console.WriteLine("string Max value  :  " + val3);
            Console.ReadLine();



        }





    }
}
