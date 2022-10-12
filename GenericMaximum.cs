using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject
{
    public class GenericMaximum<T> where T : IComparable
    {
        private T firstValue, SecondValue, ThirdValue;
        public GenericMaximum(T firstValue, T SecondValue, T Thirdvalue)
        {
            this.firstValue = firstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = Thirdvalue;
        }
        public T MaxValue()
        {
            if (firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(ThirdValue) > 0 ||
                firstValue.CompareTo(SecondValue) >= 0 && firstValue.CompareTo(ThirdValue) > 0 ||
                firstValue.CompareTo(SecondValue) > 0 && firstValue.CompareTo(ThirdValue) >= 0)
            {
                return firstValue;
            }
            if (SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(firstValue) >= 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(firstValue) > 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(firstValue) > 0 ||
              ThirdValue.CompareTo(SecondValue) >= 0 && ThirdValue.CompareTo(firstValue) > 0 ||
             ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(firstValue) >= 0)
            {
                return ThirdValue;
            }
            return firstValue;
        }
    }
}
