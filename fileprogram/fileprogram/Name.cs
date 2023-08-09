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
        // fild
        private string _input;//accesmodfier datatype Navn

        //constrostor
        public Name(string input)//access modifier referencetype, parameter
        {
            //fild with parameter called argumenter
            _input = input;
        }
        //methode
        public int Lcount() //access modifier datatype methode name
        {
            //int returntype because of .length(length is a propertys that is in all strings)
            return _input.Length;//retyrntype
        }
    }
}
//[synlighed] = access modifier
//[[static]] = ipratelse først
//[returntype] = hvilken typemetode retuneres
//navn = selv vælge
//[argumenter] = mange som man vil og skal have ()
//_ i parameter for at viser at den liger i classen
