using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using CodeSignalSolution;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var watch = Stopwatch.StartNew();

            Exercises.MakeArrayConsecutive2(new[] { 6, 2, 3, 8 });

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Assert.IsTrue(elapsedMs < 3000);
        }
    }
}
