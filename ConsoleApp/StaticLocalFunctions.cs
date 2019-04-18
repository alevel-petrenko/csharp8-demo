using System;
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

namespace ConsoleApp
{
    internal static class StaticLocalFunctions
    {
        public static void Showcase ()
        {
            var numbers = EvenNumbersLessThan (15);

            foreach (int number in numbers)
                WriteLine (number);
        }

        static IEnumerable<int> EvenNumbersLessThan (int max)
        {
            return
                Range (0, 1000)
                    .Where (Even)
                    .Where (LessThanMax);

            static bool Even (int number) => number % 2 == 0;
            bool LessThanMax (int number) => number < max;
        }
    }
}