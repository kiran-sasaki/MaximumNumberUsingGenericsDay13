using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T FirstValue, SecondValue, ThirdValue;
        public GenericMaximum(T FirstValue, T SecondValue, T Thirdvalue)
        {
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = Thirdvalue;
        }
        public static T MaxValue(T FirstValue,T SecondValue,T ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
                FirstValue.CompareTo(SecondValue) >= 0 && FirstValue.CompareTo(ThirdValue) > 0 ||
                FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) >= 0)
            {
                return FirstValue;
            }
            if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValue) >= 0 && SecondValue.CompareTo(ThirdValue) > 0 ||
                SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                return SecondValue;
            }
            if (ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(FirstValue) > 0 ||
              ThirdValue.CompareTo(SecondValue) >= 0 && ThirdValue.CompareTo(FirstValue) > 0 ||
             ThirdValue.CompareTo(SecondValue) > 0 && ThirdValue.CompareTo(FirstValue) >= 0)
            {
                return ThirdValue;
            }
            return FirstValue;
        }
        public T TestMaximum()
        {
            T max = GenericMaximum<T>.MaxValue(this.FirstValue, this.SecondValue, this.ThirdValue);
            return max;
        }
    }
}
