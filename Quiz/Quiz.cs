﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Quiz
{
    public class Quiz
    {
        // take the difrent string and lay the in ther respected string 
        public string ?Quistionstext { get; set; }
        public List<string> Options = new List<string>();
        public string ?Correctanswer { get; set; }
        public string ?Description { get; set; }
    }
    public class ParseJson
    {
        //get the json file and make it redibale
        public static List<Quiz> FetchFile()
        {
            string file = File.ReadAllText("C:\\Users\\janm\\source\\repos\\Quiz\\Qusidata.json");
            return JsonConvert.DeserializeObject<List<Quiz>>(file);
        }
    }
}