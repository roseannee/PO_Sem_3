using System;
using System.Collections.Generic;
using System.Linq;
using static lab4.Menu;

namespace lab4
{
    internal class Program
    {
        static Random random = new Random();

        static int mainMenuOption;
        static int langOption;
        static int editWordsOption;

        static bool isInVocabulary;

        static Queue<string> historyWord = new Queue<string>();
        static Queue<string> historyValue = new Queue<string>();

        static void Main(string[] args)
        {
            var vocabulary = new Dictionary<string, string>()
            {
                { "Color", "Kolor" },
                { "Air", "Powietrze" },
                { "House", "Dom" },
                { "Paper", "Papier" },
                { "Tree", "Drzewo" },
                { "Ship", "Statek" },
                { "Land", "Ziemia" },
                { "Family", "Rodzina" },
                { "Eye", "Oko" },
                { "Space", "Kosmos" },
                { "Wood", "Lasek" },
                { "City", "Miasto" },
                { "Letter", "List" },
                { "Bird", "Ptak" },
                { "Wind", "Wiatr" },
            };

            do
            {
                MainMenu();
                mainMenuOption = Convert.ToInt32(Console.ReadLine());
                switch (mainMenuOption)
                {
                    case 1:
                        string enteredWord;

                        LanguageSelection();
                        langOption = Convert.ToInt32(Console.ReadLine());

                        isInVocabulary = false;

                        if (langOption == 1)
                        {
                            Console.Write("\nEnter word: ");
                            enteredWord = Console.ReadLine();

                            foreach (var i in vocabulary)
                            {
                                if (enteredWord == i.Key)
                                {
                                    isInVocabulary = true;

                                    Console.WriteLine($"Translation: {i.Value}");

                                    historyWord.Enqueue(i.Key);
                                    historyValue.Enqueue(i.Value);

                                    break;
                                }
                            }

                            if (!isInVocabulary)
                                Console.WriteLine("There is no such word in the vocabulary!");
                        }
                        else if (langOption == 2)
                        {
                            Console.Write("\nEnter word: ");
                            enteredWord = Console.ReadLine();

                            foreach (var i in vocabulary)
                            {
                                if (enteredWord == i.Value)
                                {
                                    isInVocabulary = true;

                                    Console.WriteLine($"Translation: {i.Key}");

                                    historyWord.Enqueue(i.Value);
                                    historyValue.Enqueue(i.Key);

                                    break;
                                }
                            }

                            if (!isInVocabulary)
                                Console.WriteLine("There is no such word in the vocabulary!");
                        }

                        break;

                    case 2:
                        if (historyWord.Count != 0)
                        {
                            Console.WriteLine();

                            while (historyWord.Count > 0)
                                Console.WriteLine($"{historyWord.Dequeue()} > {historyValue.Dequeue()}");
                        }
                        else
                            Console.WriteLine("\nNo translation history!");

                        break;

                    case 3:
                        LanguageSelection();
                        langOption = Convert.ToInt32(Console.ReadLine());

                        if (langOption == 1)
                        {
                            Console.WriteLine("");

                            foreach (var i in vocabulary.OrderBy(i => i.Key))
                                Console.WriteLine($"{i.Key} > {i.Value}");
                        }
                        else if (langOption == 2)
                        {
                            Console.WriteLine("");

                            foreach (var i in vocabulary.OrderBy(i => i.Value))
                                Console.WriteLine($"{i.Value} > {i.Key}");
                        }

                        break;

                    case 4:
                        string englishWord;
                        string polishWord;
                        string deleteWord;

                        EditWords();
                        editWordsOption = Convert.ToInt32(Console.ReadLine());

                        isInVocabulary = false;

                        if (editWordsOption == 1)
                        {
                            Console.WriteLine("\nType new word:");

                            Console.Write("English: ");
                            englishWord = Console.ReadLine();

                            Console.Write("Polish: ");
                            polishWord = Console.ReadLine();

                            vocabulary.Add(englishWord, polishWord);
                        }
                        else if (editWordsOption == 2)
                        {
                            Console.Write("\nType word you want delete: ");
                            deleteWord = Console.ReadLine();

                            foreach (var i in vocabulary)
                            {
                                if (deleteWord == i.Value)
                                {
                                    isInVocabulary = true;

                                    vocabulary.Remove(deleteWord);

                                    break;
                                }
                                else if (deleteWord == i.Key)
                                {
                                    isInVocabulary = true;

                                    vocabulary.Remove(deleteWord);

                                    break;
                                }
                            }

                            if (!isInVocabulary)
                                Console.WriteLine("There is no such word in the vocabulary!");
                        }

                        break;

                    case 5:
                        int correctAnswers = 0;
                        int wrongAnswers = 0;

                        HashSet<int> usedWords = new HashSet<int>();
                        List<string> list = new List<string>();
                        foreach (var i in vocabulary)
                            list.Add(i.Key);

                        LanguageSelection();
                        langOption = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nType the number of words for the test: ");
                        int wordCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        if (langOption == 1)
                        {
                            for (int i = 0; i < wordCount; i++)
                            {
                                bool wasUsed;
                                int rand;

                                do
                                {
                                    wasUsed = false;
                                    rand = random.Next(0, list.Count);

                                    foreach (var j in usedWords)
                                        if (j == rand)
                                            wasUsed = true;

                                    usedWords.Add(rand);
                                } while (wasUsed);

                                string randKey = list[rand];
                                Console.Write($"Type translation of the word {randKey}: ");
                                string answer = Console.ReadLine();

                                if (answer == vocabulary[randKey])
                                {
                                    correctAnswers++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    wrongAnswers++;
                                    Console.WriteLine($"Incorrect! The right translation is {vocabulary[randKey]}\n");
                                }
                            }

                            Console.WriteLine($"Correct answers: {correctAnswers}\nWrong answers: {wrongAnswers}");

                            break;
                        }
                        else if (langOption == 2)
                        {
                            for (int i = 0; i < wordCount; i++)
                            {
                                bool wasUsed;
                                int rand;

                                do
                                {
                                    wasUsed = false;
                                    rand = random.Next(0, list.Count);

                                    foreach (var j in usedWords)
                                        if (j == rand)
                                            wasUsed = true;

                                    usedWords.Add(rand);
                                } while (wasUsed);

                                string randValue = list[rand];
                                Console.Write($"Type translation of the word {vocabulary[randValue]}: ");
                                string answer = Console.ReadLine();

                                if (answer == randValue)
                                {
                                    correctAnswers++;
                                    Console.WriteLine();
                                }
                                else
                                {
                                    wrongAnswers++;
                                    Console.WriteLine($"Incorrect! The right translation is {randValue}\n");
                                }
                            }

                            Console.WriteLine($"Correct answers: {correctAnswers}\nWrong answers: {wrongAnswers}");

                            break;
                        }

                        break;

                    case 0:
                        Console.WriteLine("\nExit...");
                        Environment.Exit(1);

                        break;
                }
            } while (mainMenuOption != 0);

            Console.ReadKey();
        }
    }
}
