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
        * Return true if the given string contains between 1 and 3 'e' chars.
        * ("Hello") → true
        * ("Heelle") → true
        * ("Heelele") → false
        */
        public bool StringE(string str)
        {
            int countE = 0;
           for(int i=0;i<str.Length;i++)
            {
                if(str[i]=='e')
                {
                    countE++;
                    if (countE > 3)
                        return false;
                }
            }
            if (countE == 0)
                return false;
            else
                return true;
        }
    }
}
