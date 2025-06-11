using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class FibonashiRecursion
    {
        internal long Fibonasci(int n)
        {
            if (n <= 1) return 0;
            if (n == 2) return 1;
            return Fibonasci(n - 1) + Fibonasci(n - 2);
        }
    }
}
