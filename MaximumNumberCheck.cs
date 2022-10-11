using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject
{
    public class MaximumNumberCheck
    {
        public static int MaximumIntigerNumber(int firstValue,int SecondValue,int ThirdValue)
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(ThirdValue)>0)
            {
                return firstValue;
            }
            if (SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(ThirdValue)>0)
            {
                return SecondValue;
            }
            if(ThirdValue.CompareTo(firstValue)>0 && ThirdValue.CompareTo(SecondValue)>0)
            {
                return ThirdValue;
            }
            return firstValue;
        }
    }
}
