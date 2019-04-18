using System;
using System.IO;
using static System.Console;

// ReSharper disable UseUsingVarLocalVariable

namespace ConsoleApp
{
    internal static class UsingDeclarations
    {
        public static void Showcase ()
        {
            //Before ();
            After ();
        }

        static void Before ()
        {
            using (var stream = new MemoryStream ())
            using (var writer = new StreamWriter (stream) { AutoFlush = true })
            {
                using (var reader = new StreamReader (stream))
                    WriteLine (reader.ReadToEnd ());

                writer.Write ("Memory stream contains this.");

                stream.Position = 0;
            }
        }

        static void After ()
        {
            using var stream = new MemoryStream();
            using var writer = new StreamWriter(stream) { AutoFlush = true };

            writer.Write("Memory stream contains this.");

            stream.Position = 0;

            using var reader = new StreamReader(stream);

            WriteLine(reader.ReadToEnd());
        }
    }
}