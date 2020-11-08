using System;
using System.Collections.Generic;

namespace QuestionnaireApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine(" --= Questionnaire for students =--");

                Random rnd = new Random();
                string[] randomQuestion =
                {
                    "1", "2", "3", "4", "5"
                };

                // Generate random indexes for pet names.
                int mIndex = rnd.Next(randomQuestion.Length);

                // Display the result.
                Console.WriteLine("   Question number:     {0}", randomQuestion[mIndex]);

                Dictionary<int, string> countries = new Dictionary<int, string>(5);
                countries.Add(1, "How create folder?");
                countries.Add(2, "What types of data do you know?");
                countries.Add(3, "How many months are there?");
                countries.Add(4, "What arithmetic operations do you know?");
                countries.Add(5, "What conditional constructions do you know?");

                foreach (KeyValuePair<int, string> keyValue in countries)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }

                Console.ReadLine();

                switch (mIndex)
                {
                    case 0:
                        Console.WriteLine("Correct answer: \n Right click on the desktop and select 'add folder'");
                        break;
                    case 1:
                        Console.WriteLine("Correct answer: \n Bool, byte, string, decimal, double, int, float");
                        break;
                    case 2:
                        Console.WriteLine("Correct answer: \n 12");
                        break;
                    case 3:
                        Console.WriteLine("Correct answer: \n +, -, *, /, %");
                        break;
                    case 4:
                        Console.WriteLine("Correct answer: \n if/else, switch");
                        break;
                }
                Console.WriteLine("Press any key for next question\nor press 'q' for quit...");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}