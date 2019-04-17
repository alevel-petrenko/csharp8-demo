using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Tasks.Task;

namespace ConsoleApp
{
    internal class AsyncStreams
    {
        public static async Task Showcase()
        {
            await foreach (var value in Sequence())
                WriteLine(value);
        }

        static async IAsyncEnumerable<int> Sequence()
        {
            for (int i = 0; i < 60; i++)
            {
                yield return i;
                await Delay (1000);
            }
        }
    }
}