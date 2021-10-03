using System;
using System.Collections.Generic;
using System.Text;

namespace SortingMax
{
    class UC5
    {
        public class GenricMaximum<T> where T : IComparable
        {
            public T[] value;
            public GenricMaximum(T[] value)
            {
                this.value = value;
            }
            public T[] sort(T[] values)
            {
                var sorted_values = sort(values);
                return sorted_values;


            }
            public T MaxMethod()
            {
                var max = MaxValue(this.value);
                return (T)max;
            }
            public void PrintMaxValue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum Value is" + max);
            }

            private object MaxValue(T[] value)
            {
                throw new NotImplementedException();
            }
        }

        private static void Main(string[] args);
        int[] arr = { 111, 344, 432, 555, 678 };
        GenricMaximum<int> genric = new GenricMaximum<int>(arr);

        GenricPrintValue();

    }
}
