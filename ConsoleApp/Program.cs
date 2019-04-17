using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using static System.String;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main (string[] args)
        {
            //Intro.Speak ();
            //IndicesAndRanges.Showcase ();
            await AsyncStreams.Showcase ();
        }
    }
}
