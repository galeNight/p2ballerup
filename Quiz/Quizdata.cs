using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Quiz
{
    public class Quizdata
    {
        // take the difrent string and lay the in ther respected string 
        public string ?Quistionstext { get; set; }
        public List<string> Options = new List<string>();
        public string ?Correctanswer { get; set; }
        public string ?Description { get; set; }
    }
    public class ParseJson
    {
        //get the json file and make it readeble
        public static List<Quizdata> FetchFile()
        {
            string file = File.ReadAllText("C:\\Users\\janm\\source\\repos\\Quiz\\myjson.json");
            return JsonConvert.DeserializeObject<List<Quizdata>>(file);
        }

    }
}