using System.Diagnostics;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestFibonashi.Test(20);

            //TestFibonashi.Test(5); Rec: 95400
            //                      Loop:100400
            //TestFibonashi.Test(10);Rec: 89700
            //                      Loop: 95900
            //TestFibonashi.Test(20);Rec:189200
            //                      Loop:106000



            Console.WriteLine("Program Complite.");
        }
    }
}
