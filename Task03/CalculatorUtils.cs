using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class CalculatorUtils
    {
        public static int AddMultiple(int[] list)
        {
            return list.Sum();
        }

        public static int Add(int a, int b)
        {            
            return a + b;
        }

        public static int[] GetMultipleList(int divider, int minValue, int maxValue)
        {
            List<int> list = new List<int>();
            int i = minValue;
            do
            {
                if(i % divider == 0)
                {
                    list.Add(i);
                }
                i++;
            } while (i < maxValue);

            return list.ToArray();
        }
    }
}
