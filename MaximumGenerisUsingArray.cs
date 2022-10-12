using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject
{
    public class MaximumGenericsUsingArray<T> where T : IComparable
    {
        public T[] value;

        public MaximumGenericsUsingArray(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        public T MaxMethod()
        {
            var Max = MaxValue(value);
            return Max;
        }
        public void PrintMaxValue()
        {
            var Max = MaxValue(this.value);
            Console.WriteLine("Max value is: " + Max);
        }
    }
}
