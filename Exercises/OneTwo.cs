using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        * Given a string, compute a new string by moving the first char to come after the next two chars, so "abc" yields "bca". 
        * Repeat this process for each subsequent group of 3 chars, so "abcdef" yields "bcaefd". 
        * Ignore any group of fewer than 3 chars at the end.
        *
        * oneTwo("abc") → "bca"
        * oneTwo("tca") → "cat"
        * oneTwo("tcagdo") → "catdog"
        */
        public string OneTwo(string str)
        {
            string firstchar;
            string substr;
            string newString="";
            if (str.Length < 3) return "";
            else
            {
                for(int i=0;i<str.Length-2;i+=3)
                {
                    firstchar = str.Substring(i,1);
                    substr = str.Substring(i + 1, 2);
                    newString = newString + substr + firstchar;
                }
            }
            return newString;
        }
    }
}
