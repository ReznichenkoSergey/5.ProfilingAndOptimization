using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace GeneratePasswordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stop = new Stopwatch();
            stop.Start();

            var arr = Enumerable
                .Range(0, 16)
                .Select(x=>(byte)x).ToArray();

            var test = new TestClass();
            for (var i = 0; i < 1000; i++)
            {
                test.GeneratePasswordHashUsingSalt("verylongpassword", arr);
            }

            stop.Stop();
            Console.WriteLine($"Ticks= {stop.ElapsedTicks}");

            Console.ReadLine();
        }
    }
}
