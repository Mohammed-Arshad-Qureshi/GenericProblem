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

        static void Main(string[] args)
        {
            string maxValue = Program.MaximumCheck(3, 2, 3).ToString();
            Console.WriteLine("The maximum of Three numbers :  " + maxValue);
            Console.ReadLine(); 
        }
    }
}
