using System;

namespace QuestionnaireApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" --= Questionnaire for students =--");

                Random rnd = new Random();
                string[] randomQuestion = { "1", "2", "3", "4",
                    "5", "6", "7", "8",
                    "9", "0" };

                // Generate random indexes for pet names.
                int mIndex = rnd.Next(randomQuestion.Length);

                // Display the result.
                Console.WriteLine("   Question number:     {0}", randomQuestion[mIndex]);

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