using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class FibonasciLoop
    {
        internal long Fibonasci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            long a = 0;
            long b = 1;

            for (int i = 2; i <= n; i++)
            {
                (a, b) = (b, a + b);
            }
            return b;
        }
    }
}
