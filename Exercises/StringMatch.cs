﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        * Given 2 strings, a and b, return the number of the positions where they contain the same length 
        * 2 substring. So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and "az" 
        * substrings appear in the same place in both strings.        * 
        *
        * stringMatch("xxcaazz", "xxbaaz") → 3
        * stringMatch("abc", "abc") → 2
        * stringMatch("abc", "axc") → 0  
        */
        public int StringMatch(string a, string b)
        {
            int length = 0, count = 0;
            string substra, substrb;

            if (a.Length > b.Length)
                length = b.Length;
            else
                length = a.Length;

            for(int i= 0;i<length-1;i++)
            {
                substra = a.Substring(i, 2);
                substrb = b.Substring(i, 2);
                if(substra==substrb)
                {
                    count++;
                } 
            }
            return count;
        }
    }
}
