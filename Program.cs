using System;

namespace Planner
{
    class Program
    {
        static void Main()
        {
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    DateTwo();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.Clear();

                Menu();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }

            if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("Площадь Гагарина в 14:00");
            }
            else if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("Сделать задания по философии и дискретке до 00:00");
            }

        }
        static void Menu()
        {
            Console.WriteLine("  Выбрана дата 09.10.2022");
            Console.WriteLine("  1.Погулять");
            Console.WriteLine("  2.Сделать дз");
        }
        static void DateTwo()
        {
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    Main();
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    DateThree();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }


                Console.Clear();

                Console.WriteLine("  Выбрана дата 10.10.2022");
                Console.WriteLine("  1.Сходить к врачу");
                Console.WriteLine("  2.Доделать дз");
                Console.WriteLine("  3.Поигать в геншин");

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }

            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine("Запись у врача в 12:00");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("Доисать конспет по архитектуре");
            }
            else if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("Выполнить сюжетный квест");
            }

        }
        static void DateThree()
        {
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    DateTwo();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.Clear();

                Console.WriteLine("  Выбрана дата 11.10.2022");
                Console.WriteLine("  1.Прийти на пары");
                Console.WriteLine("  2.Сходить в магазин");
                Console.WriteLine("  3.Поигать в геншин");

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }

            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine("С 8:30 до 13:30");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine("Купить что-то съедобное");
            }
            else if (position == 3)
            {
                Console.Clear();
                Console.WriteLine("Нафармить арты для Тигнари");
            }
        }
    }
}