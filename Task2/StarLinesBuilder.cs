using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class StarLinesBuilder
    {
        public static void Build(int n)
        {
            var line = new StringBuilder();
            for (int i = 0; i <= n; i++)
            {
                line.Append("*");
                Console.WriteLine(line);
            }
        }
    }
}
