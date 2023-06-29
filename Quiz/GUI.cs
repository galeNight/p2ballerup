using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Quiz
{
    internal class GUI
    {
        public GUI()// the data from the json file is use here to run a quiz
        {
            List<Quiz> QuizData = ParseJson.FetchFile(); //list with data from json file

            foreach (Quiz quiz in QuizData) // foreach loop that run the data from quiz thro
            {
                Console.Clear();

                int consoleWith = Console.WindowWidth;
                int questionLegnth = quiz.Quistionstext.Length;
                int leftMargin = (consoleWith - questionLegnth) / 2;

                int optionsMaxWidth = quiz.Options.Max(opt => opt.Length);//center-aline quistion
                int optionsLeftMargin = (consoleWith - optionsMaxWidth) / 2;

                Console.SetCursorPosition(leftMargin,Console.CursorTop);
                Console.WriteLine(quiz.Quistionstext); //print Quistionstext from list

                foreach (string options in quiz.Options)// print Options from list
                {
                    Console.SetCursorPosition(optionsLeftMargin, Console.CursorTop);//center-aline option
                    Console.WriteLine(options); // prints the choice 
                }

                int promptLength = "Write your answer: ".Length;
                int promptLeftMargin = (consoleWith - promptLength) / 2;
                Console.SetCursorPosition(promptLeftMargin, Console.CursorTop);
                Console.Write("Write you answer: ");

                string userAnswer = Console.ReadLine();//write the choice

                if (userAnswer.ToLower() == quiz.Correctanswer.ToLower()) // if statment about you chice is correct or not
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rigtig");
                    Console.WriteLine(quiz.Description);// correct choice and facts about the quistion
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Forkert"); // print wrong answer
                }
                Console.WriteLine();
                Console.WriteLine("Press any ket to continue...");
                Console.ResetColor();
                Console.ReadKey();

            }

            Console.WriteLine("Quiz Completed!");//print quis completet
        }
    }
}