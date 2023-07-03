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
                Console.Clear();//clear the the text 

                Console.WriteLine(quiz.Quistionstext); //print Quistionstext from list

                foreach (string options in quiz.Options)// print Options from list
                {
                    Console.WriteLine(options); // prints the choice 
                }

                Console.Write("Write you answer:");

                string userAnswer = Console.ReadLine();//write the choice

                if (userAnswer.ToLower() == quiz.Correctanswer.ToLower()) // if statment about you chice is correct or not
                {
                    Console.WriteLine("Rigtig!\n");
                    Console.WriteLine(quiz.Description);// correct choice and facts about the quistion
                }
                else
                {
                    Console.WriteLine("Forkert!\n");//print wrong choice
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...\n");//print continue
                Console.ReadKey();
            }
            Console.WriteLine("quiz complete");//print complete
            Console.ReadKey();
        }
    }
}