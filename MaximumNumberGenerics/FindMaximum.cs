using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberGenerics
{
    public class FindMaximum
    {
        public static int FindMaximumInt(int firstValue, int secondValue, int thirdValue) 
        {
        
            if (firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue) > 0) 
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
            throw new Exception("Some/All the values are same.");
        }
    }
}
