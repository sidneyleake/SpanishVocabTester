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
                    Console.WriteLine("How many verbs would you like to practice?");
                    var count = Console.ReadLine();
                    RunTester(Quiz.Verbs, int.Parse(count));
                }
            }

        }

        private static void RunTester(Dictionary<string, string> words, int count = 0)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var generator = new Random(DateTime.Now.Millisecond);
            var input = String.Empty;
            var guessCount = 0;
            var correctCount = 0;
            var wordList = Shuffle(words.ToArray());
            var index = 0;

            if(count > 0)
            {
                wordList = wordList.Take(count).ToArray();
            }
            

            Console.WriteLine("Enter STOP to return to main menu.");
            while (input != "STOP")
            {
                Console.WriteLine();
                var word = wordList.Skip(index).Take(1).Single();
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

                index++;
                if(index >= wordList.Length)
                {
                    index = 0;
                    wordList = Shuffle(wordList);
                }
            }
        }

        private static string Normalize(string word)
        {
            return word
                .ToLower()
                .Replace(" ", string.Empty);
        }

        private static KeyValuePair<string, string>[] Shuffle(KeyValuePair<string, string>[] words)
        {
            var generator = new Random(DateTime.Now.Millisecond);
            var n = words.Count();
            while (n > 1)
            {
                n--;
                var k = generator.Next(n + 1);
                var value = words[k];
                words[k] = words[n];
                words[n] = value;
            }

            return words;
        }
    }
}
