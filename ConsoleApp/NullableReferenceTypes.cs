﻿using System;
using ClassLibrary;
using static System.Console;

namespace ConsoleApp
{
    internal static class NullableReferenceTypes
    {
        public static void Demo () => Demo1 (); // of 5

        static void Demo1 ()
        {
            LogDoubleLength ("12345");
            LogDoubleLength ("1234567890");
        }

        static void LogDoubleLength (string value)
        {
            int length = Length (value);
            int doubleLength = 2 * length;
            WriteLine (doubleLength);
        }

        static int Length (string s) => s.Length;

        static void Demo2 ()
        {
            LogLength ("12345");
            // TODO: LogLength (null);
        }

        static void LogLength (string value) => WriteLine (Length (value));

        static void Demo3 ()
        {
            string? format = null;
            var message = string.Format (format, 1);

            WriteLine (message);
        }

        static void Demo4 ()
        {
            Module.LogLength ("12345");
            // TODO: Module.LogLength (null);
        }

        static void Demo5 ()
        {
            #nullable disable

            Module.LogLength (null);

            #nullable restore
        }
    }
}