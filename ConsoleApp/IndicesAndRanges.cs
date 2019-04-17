using System;
using System.Linq;
using static System.Console;

namespace ConsoleApp
{
    public static class IndicesAndRanges
    {
        const string TearsInRain =
            "I've seen things you people wouldn't believe. " + // 7
            "Attack ships on fire off the shoulder of Orion. " + // 9
            "I watched C-beams glitter in the dark near the Tannhäuser Gate. " + // 11
            "All those moments will be lost in time, like tears in rain. " + // 12
            "Time to die."; // 3

        public static void Demo () => Demo1 (); // of 5

        static void Demo1 ()
        {
            string[] words = TearsInRain.Split (' ');

            WriteLine (words[3]); // you
            WriteLine (words[5]); // wouldn't
            WriteLine (words[41]); // die
        }

        static void Demo2 ()
        {
            string[] words = TearsInRain.Split (' ');

            for (int index = 0; index < words.Length; index++)
                WriteLine (words[index]);
        }

        static void Demo3 ()
        {
            string[] words =
            {
                "I've", "seen", "things", "you", "people", "wouldn't", "believe."
            };

            string[] range = words[1..3]; // play here

            WriteLine (string.Join (' ', range));
        }

        static void Demo4 ()
        {
            Span<string> words = TearsInRain.Split(' ').AsSpan();

            var lastWords = words[^3..];

            foreach (var word in lastWords)
                WriteLine (word);
        }

        static void Demo5 ()
        {
            Span<string> words = TearsInRain.Split(' ').AsSpan();

            var lastWords = words[^3..];

            lastWords[^1] = "live.";

            foreach (var word in words)
                WriteLine(word);
        }
    }
}