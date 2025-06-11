using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class TestFibonashi
    {
        internal static void Test(int count)
        {
            FibonashiRecursion fibonashiRecursion = new FibonashiRecursion();
            FibonasciLoop fibonasciLoop = new FibonasciLoop();
            Stopwatch sw = new Stopwatch();
            sw.Reset();

            sw.Start();
            fibonashiRecursion.Fibonasci(count);
            sw.Stop();

            Console.WriteLine($"FibonashiRecurtion({count}):\n{sw.Elapsed.TotalNanoseconds} наносекунд.\n");
            sw.Reset();

            sw.Start();
            fibonasciLoop.Fibonasci(count);
            sw.Stop();

            Console.WriteLine($"FibonasciLoop({count}):\n{sw.Elapsed.TotalNanoseconds} наносекунд.\n");
        }
    }
}
