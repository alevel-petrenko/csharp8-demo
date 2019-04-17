namespace ConsoleApp
{
    class Intro
    {
        public static void Speak()
        {
            Setup();
            Panic();
        }

        static void Setup()
        {
            //C# 8.0 (Beta)
            //https://dotnet.microsoft.com/download/dotnet-core/3.0
            //Tools -> Options -> Project and Solutions -> .NET Core
        }

        static void Panic()
        {
            //git clean -fxd
            //dotnet restore
            //dotnet build
            //dotnet run
        }
    }
}