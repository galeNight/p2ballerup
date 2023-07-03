using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz;
namespace Quiz
{
    internal class GUI
    {

        private readonly metodes obj = new metodes();
        public GUI()// the data from the json file is use here to run a quiz
        {

            List<Quizdata> QuizData = ParseJson.FetchFile(); //list with data from json file

            foreach (Quizdata quiz in QuizData) // foreach loop that run the data from quiz thro
            {
                Console.Clear();//clear the the text 

                obj.text(quiz.Quistionstext);

                Console.WriteLine(quiz.Quistionstext); //print Quistionstext from list

                foreach (string options in quiz.Options)// print Options from list
                {
                    obj.option(options);
                }

                obj.writeanswer();

                string userAnswer = Console.ReadLine();//write the choice

                if (userAnswer.ToUpper() == quiz.Correctanswer.ToUpper()) // if statmentk about you choice is correct or not
                {
                    obj.correct(quiz.Description);
                }
                else
                {
                    obj.wrong();
                }
                obj.keycontinue();
            }
            obj.complete();
        }
    }
}