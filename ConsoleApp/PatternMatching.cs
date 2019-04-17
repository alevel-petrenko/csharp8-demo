using System;
using static System.Console;
using static ConsoleApp.Day;
using static ConsoleApp.Price;
using static ConsoleApp.Priority;

namespace ConsoleApp
{
    enum Day { Yesterday, Today, Tomorrow }
    enum Price { Expensive, Cheap }
    enum Priority { Low, Normal, High }

    internal class PatternMatching
    {
        public static void Demo () => Demo1 (Yesterday); // of 4

        static void Demo1 (Day day)
        {
            var date =
                day switch
                {
                    Yesterday => DateTime.Today.AddDays (-1),
                    Today     => DateTime.Today,
                    Tomorrow  => DateTime.Today.AddDays (-1),
                    _         => throw new ArgumentOutOfRangeException (nameof(day)),
                };

            WriteLine (date); // TODO: refactor
        }

        static void Demo2 ()
        {
            var task = new Task (price: Expensive, estimate: Tomorrow);
            var priority = Priority (task);
            WriteLine (priority);
        }

        static Priority Priority (Task task) =>
            task switch
            {
                { Price:    Expensive } => High,
                { Estimate: Yesterday } => High,
                { Estimate: Tomorrow }  => Low,
                _                       => Normal, // TODO: Bug
            };

        static void Demo3 () =>
            WriteLine (Priority (Tomorrow, Cheap));

        static Priority Priority (Day estimate, Price price) =>
            (price, estimate) switch
            {
                (Expensive, _) => High,
                (_, Yesterday) => High,
                (_, Tomorrow)  => Low,
                _              => Normal,
            };

        static void Demo4()
        {
            var feature = new Feature (price: Expensive, estimate: Today);
            var priority = Priority(feature);
            WriteLine(priority);
        }

        static Priority Priority (Feature feature) =>
            feature switch
            {
                (Expensive, _) => High,
                (_, Yesterday) => High,
                (_, Tomorrow)  => Low,
                _ =>           Normal, // TODO: Enhancement
            };

        class Task
        {
            public Task (Price price, Day estimate)
            {
                Price = price;
                Estimate = estimate;
            }

            public Price Price { get; }
            public Day Estimate { get; }
        }

        class Bug : Task
        {
            public Bug (Price price, Day estimate) : base(price, estimate) { }
        }

        class Feature : Task
        {
            public Feature (Price price, Day estimate) : base (price, estimate) { }

            public void Deconstruct (out Price price, out Day estimate)
            {
                price = Price;
                estimate = Estimate;
            }
        }

        class Enhancement : Feature
        {
            public Enhancement (Price price, Day estimate) : base (price, estimate) { }
        }
    }
}