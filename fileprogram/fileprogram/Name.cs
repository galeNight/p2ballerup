using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileprogram
{
    //public is access modifier and class is referencetype
    public class Name

    {
        // fild with parameter
        private string _input;

        //constrostor, access modifier referencetype and parameter
        public Name(string input)
        {
            //fild with parameter
            _input = input;
        }
        // int metode
        public int Lcount()
        {
            //int returntype because of .length(length is a propertys that is in all strings)
            return _input.Length;
        }
    }

}
