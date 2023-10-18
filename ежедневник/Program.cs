using System.ComponentModel.Design;

namespace ежедневник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 1;
            Menu();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                Console.Clear();
                Menu();
                Console.SetCursorPosition(0, position + 1);
                Console.WriteLine("->");
                if (position == 0)
                {
                    Console.WriteLine("Фу");
                }
                else if (position == 1)
                {
                    Console.WriteLine("Кофе чёрный, как я");
                }
                else if (position == 2)
                {
                    Console.WriteLine("Хорошая погодка");
                }
                else if (position == 3)
                {
                    Console.WriteLine("Сладких снов");
                }
            }
        }

        static void Menu()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Ежедневник!");
            Console.WriteLine("  1. Закинуть снюс");
            Console.WriteLine("  2. Попить кофе");
            Console.WriteLine("  3. Сходить погулять");
            Console.WriteLine("  4. Поспать с кайфом");
        }
    }
}