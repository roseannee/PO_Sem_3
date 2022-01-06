using System;

namespace lab4
{
    internal class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("\n--- TRANSLATION ---" +
                           "\n 1. Translator" +
                           "\n 2. History\n");
            Console.WriteLine("--- VOCABULARY ---" +
                           "\n 3. Show vocabulary" +
                           "\n 4. Edit vocabulary\n");
            Console.WriteLine("--- TEST ---" +
                           "\n 5. Start test");
            Console.WriteLine("\n 0. END");

            Console.Write("\nOption: ");
        }

        public static void LanguageSelection()
        {
            Console.WriteLine("\n 1. English --> Polish" +
                              "\n 2. Polish --> English");
            Console.WriteLine("\n 0. END");

            Console.Write("\nOption: ");
        }

        public static void EditWords()
        {
            Console.WriteLine("\n 1. Add word" +
                              "\n 2. Delete word");
            Console.WriteLine("\n 0. END");

            Console.Write("\nOption: ");
        }
    }
}
