using static System.Console;

namespace ConsoleApp
{
    internal class DisposableRefStructs
    {
        public static void Showcase ()
        {
            using (var x = new RefStruct ())
                WriteLine("I pretend to use ref struct here.");
        }

        internal ref struct RefStruct
        {
            public void Dispose () => WriteLine ("Ref Struct successfully disposed.");
        }
    }
}