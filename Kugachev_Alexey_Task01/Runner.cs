using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Runner
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Введите параметры прямоугольника");
            int a = InputUtils.EnterInteger();
            int b = InputUtils.EnterInteger();
            Console.WriteLine("Определяем площадь прямоугольника со сторонами '{0}' и '{1}'", a, b);
            Calculator.Multiply(a, b);
            Console.ReadKey();
        }        
    }
}
