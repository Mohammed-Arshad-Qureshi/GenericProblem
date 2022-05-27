using System;

namespace Generics
{
    class Program
    {
        #region Maxium integer value
        public static int MaximumCheck(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
        #endregion

        #region Maximum Double value
        public static double MaximumFloatCheck(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;

        }
        #endregion

        #region String Number Maximum
        public static string MaximumStringNumber(string firstValue, string secondValue, string thirdValue)
        {
            if ((firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0) ||
               (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0) ||
               (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }
            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue).CompareTo(firstValue) >= 0 && (secondValue.CompareTo(thirdValue) > 0) ||
                (secondValue).CompareTo(firstValue) > 0 && (secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }
            if ((thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0) ||
                (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0) ||
                    (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0))
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue and thirdValue are same");
        }
        #endregion

        static void Main(string[] args)
        {
            int intMaxValue = Program.MaximumCheck(3, 2, 3);
            Console.WriteLine("The maximum of Three integer numbers  :  " + intMaxValue);

            double floatMaxValue = Program.MaximumFloatCheck(1.2, 1.2, 1.3);
            Console.WriteLine("\nThe maximum of Three double numbers   :  " + floatMaxValue);

            string stringMaxValue = Program.MaximumStringNumber("1","2","3");
            Console.WriteLine("\nThe maximum of Three double numbers   :  " + stringMaxValue);
            Console.ReadLine();
        }
    }
}
