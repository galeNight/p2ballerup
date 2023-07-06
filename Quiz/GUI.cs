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

                obj.text(quiz.Quistionstext); //print Quistionstext from list

                foreach (string options in quiz.Options)// print Options from list
                {
                    obj.option(options);//print options for quistiontext
                }

                obj.writeanswer();// print answer for option

                string userAnswer = Console.ReadLine();//read you anser and put it in a string 

                if (userAnswer.ToUpper() == quiz.Correctanswer.ToUpper()) //uses you answer and check if it is correct
                {
                    obj.correct();//print correct
                    obj.facts(quiz.Description);// fact about the quistion when you answer correct
                }
                else
                {
                    obj.wrong();//print wrong 
                    obj.facts(quiz.Description);// fact about the quistion when you answer wrong
                }
                obj.keycontinue();//print press eny key to contuinue
            }
            obj.complete();//orint quiz complete
        }
    }
}