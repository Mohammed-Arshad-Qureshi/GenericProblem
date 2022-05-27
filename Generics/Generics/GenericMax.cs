using System;

namespace Generics
{
    public class GenericMax<T> where T : IComparable
    {
        T firstValue;
        T secondValue;
        T thirdValue;
        public GenericMax(T firstValue, T secondValue,T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;

        }
        #region Any type of number Maximum
        public static T MaximumAnyNumber(T firstValue, T secondValue, T thirdValue)
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
            return firstValue;
        }
        
        public T MaxMethod()
        {
            T max = GenericMax<T>.MaximumAnyNumber(firstValue, secondValue, thirdValue);
            return max;
        }
        #endregion

      
    }
}
