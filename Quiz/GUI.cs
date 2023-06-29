using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class GUI
    {
        public GUI()
        {
            List<Quiz> QuizData = ParseJson.FetchFile();

            foreach (Quiz quiz in QuizData)
            {
                Console.WriteLine(quiz.Quistionstext);

                foreach (string options in quiz.Options)
                {
                    Console.WriteLine(options);
                }
                Console.Write("Write you answer: ");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == quiz.Correctanswer.ToLower())
                {
                    Console.WriteLine("Rigtig");
                    Console.WriteLine(quiz.Description);
                }
                else
                {
                    Console.WriteLine("Forkert");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Quiz Completed!");
        }
    }
}
