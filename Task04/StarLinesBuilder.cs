using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class StarLinesBuilder
    {
        public static void Build(int n)
        {
            int maxStars = n * 2 - 1;
            int middle = maxStars / 2 + 2;

            var line = new StringBuilder();
            line.Append("*");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(line.ToString().PadLeft(middle++));
                line.Append("**");
            }
        }
    }
}
