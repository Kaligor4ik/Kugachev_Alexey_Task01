using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        private const int minValue = 0;
        private const int maxValue = 1000;
        private const int divider3 = 3;
        private const int divider5 = 5;

        static void Main(string[] args)
        {
            //5
            int[] arrMultiple5 = CalculatorUtils.GetMultipleList(divider5, minValue, maxValue);
            Console.WriteLine("Определяем массив чисел от {0} до {1}, кратных {2}: ", minValue, maxValue, divider5);
            PrintArr(arrMultiple5);

            int sum5 = CalculatorUtils.AddMultiple(arrMultiple5);       
            Console.WriteLine("\nСумма чисел от {0} до {1}, кратных {2} равна: {3}", minValue, maxValue, divider5, sum5);
            
            //3
            int[] arrMultiple3 = CalculatorUtils.GetMultipleList(divider3, minValue, maxValue); ;
            Console.WriteLine("\nОпределяем массив чисел от {0} до {1}, кратных {2}: ", minValue, maxValue, divider3);
            PrintArr(arrMultiple3);

            int sum3 = CalculatorUtils.AddMultiple(arrMultiple3);
            Console.WriteLine("\nСумма чисел от {0} до {1}, кратных {2} равна: {3}", minValue, maxValue, divider3, sum3);

            //5 + 3
            Console.WriteLine("\nСумма чисел от {0} до {1}, кратных {2} и {3} равна: ", minValue, maxValue, divider3, divider5);
            Console.WriteLine("{0} + {1} = {2}", sum3, sum5, CalculatorUtils.Add(sum3, sum5));
            Console.ReadKey();
        }

        static void PrintArr(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write("{0}; ", i);
            }
        }
    }
}
