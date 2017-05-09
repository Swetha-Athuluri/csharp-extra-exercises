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
        CHALLENGE: Given a string, return the length of the largest "block" in the string. 
        A block is a run of adjacent chars that are the same.

        maxBlock("hoopla") → 2
        maxBlock("abbCCCddBBBxx") → 3
        maxBlock("") → 0
        */
        public int MaxBlock(string str)
        {
            int maxRepeateLetters = 1, count = 0;
            if (str.Length == 0)
                return 0;
            for (int i=0;i<str.Length-1;i++)
            {
                if(str[i]==str[i+1])
                {
                    if (count == 0)
                        count = 2;
                    else count++;
                }
                else
                {
                    if (count >= maxRepeateLetters)
                    {
                        maxRepeateLetters = count;
                        

                    }
                    count = 0;
                }
            }
           if(count>=2)
            {
                if (count > maxRepeateLetters) return count;

            }
            return maxRepeateLetters;
        }
    }
}
