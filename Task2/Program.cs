using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество линий N: ");
            int n = InputUtils.EnterInteger();
            Console.WriteLine("Выводим звездочки на экран: ");
            StarLinesBuilder.Build(n);
            Console.ReadKey();
        }
    }
}
