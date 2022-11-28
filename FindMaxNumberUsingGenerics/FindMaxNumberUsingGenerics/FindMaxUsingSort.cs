using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumberUsingGenerics
{
    public class FindMaxUsingSort<T> where  T : IComparable<T>
    {
        public T[] value;

        public FindMaxUsingSort(T[] value)
        {
            this.value = value;
        }


        public void sort()
        {
           Array.Sort(value);
            var max = value[^1];
            Console.WriteLine(max);

        }
    }
}
