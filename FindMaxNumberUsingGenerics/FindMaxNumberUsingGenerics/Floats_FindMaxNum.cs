using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumberUsingGenerics
{
    internal class Floats_FindMaxNum
    {
        public static float Find_Max_num(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0
              || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0
              || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0
              || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0
              || num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0
              || num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0
              || num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            return 0;
        }
    }
}
