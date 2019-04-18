using System;
using static System.Console;

namespace ConsoleApp
{
    internal static class Tickets
    {
        static readonly string[] Attendees =
        {
            "Kateryna Revvo",
            "Никита Брик",
            "Никита Таушанов",
            "Алексей Науменко",
            "Рубен Марков",
            "Иван Калугин",
            "Дмитрий Коверя",
            "Ирина Солошенко",
            "Джошуа Лайт",
            "Валентин Хильчук",
            "Дмитри Моисеенко",
            "Павел Стовпивский",
            "Влад Вигівський",
            "Игорь Степанов",
            "Александра Строна",
            "Ruslan Seleznov",
            "Карачевцев Евгений",
            "Виталий Бабичев",
            "Рейдан Абди",
            "Eugene Vykhodtsev",
            "Костя Кравцов",
            "Евгений Пиво",
            "Богдан Змеевской",
            "Александр Будько",
            "Владислав Гмыря",
            "Артем Ганжа",
            "Павел Пилецкий",
            "Карина Лесняк",
            "Вадим Закусило",
            "Алексей Ермак",
            "Дмитрий Мисливец",
            "Яков Олейник",
            "Вадим Водолазкий",
            "Алексей Шкумат",
            "Вадим Корсун",
            "Богдан Коржук",
            "Elena Khalabuzar",
            "Александр Новицкий",
            "Сергей Черныш",
            "Сергей Руденко",
        };

        static readonly Random random = new Random ();

        public static void Giveaway ()
        {
            //Яков Олейник
            //Сергей Руденко
            //Александра Строна

            WriteLine (RandomAttendee ());
            WriteLine (RandomAttendee ());
            WriteLine (RandomAttendee ());
        }

        static string RandomAttendee () => Attendees [random.Next (Attendees.Length)];
    }
}