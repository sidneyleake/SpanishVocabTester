namespace SpanishVocabTester
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            while (input != "STOP")
            {
                Console.Clear();
                Console.WriteLine("Enter 1 to use the vocab tester and two to use the verb tester. Enter STOP to quit.");
                input = Console.ReadLine();
                if(input == "1")
                {
                    RunTester(Quiz.Vocab);
                }
                else if(input == "2")
                {
                    RunTester(Quiz.Verbs);
                }
            }

        }

        private static void RunTester(Dictionary<string, string> words)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var generator = new Random(DateTime.Now.Millisecond);
            var input = String.Empty;
            var guessCount = 0;
            var correctCount = 0;
            Console.WriteLine("Enter STOP to return to main menu.");
            while (input != "STOP")
            {
                Console.WriteLine();
                var index = generator.Next(words.Count);
                var word = words.Skip(index).Take(1).Single();
                Console.WriteLine("Translate: {0}", word.Key);
                input = Console.ReadLine();
                if (input != "STOP")
                {
                    guessCount++;
                    var guesses = input.Replace(" ", string.Empty).Split(',');
                    var incorrectGuesses = 0;
                    foreach (var guess in guesses)
                    {
                        if (!Normalize(word.Value).Contains(Normalize(guess)))
                        {
                            incorrectGuesses++;
                        }
                    }

                    if (incorrectGuesses > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not quite correct.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("That's correct.");
                        correctCount++;
                    }

                    Console.ResetColor();
                    Console.WriteLine("{0} -> {1}", word.Key, word.Value);
                    Console.WriteLine("Your score: {0}/{1} - {2}%", correctCount, guessCount, Math.Round(((double)correctCount / (double)guessCount) * 100f, 2));
                }
            }
        }

        private static string Normalize(string word)
        {
            return word
                .ToLower()
                .Replace(" ", string.Empty);
        }
    }
}
