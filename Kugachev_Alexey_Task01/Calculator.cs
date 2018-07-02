using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Calculator
    {
        public static int Multiply(int a, int b)
        {
            int result = a * b;
            Console.Write("Результат умножения: {0}", result);
            return result;
        }
    }
}
