using static System.Console;

namespace ClassLibrary
{
    public static class Module
    {
        public static int Length (string s) => s.Length;
        public static void LogLength (string value) => WriteLine (Length (value));

        public static int? LengthUnsafe (string? s) => s?.Length;
        public static void LogLengthUnsafe (string? value) => WriteLine (LengthUnsafe (value));
    }
}
