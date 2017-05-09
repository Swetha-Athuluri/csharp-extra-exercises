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
        * Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in 
        * the array. Return true if the array does not contain any triples.        
        *
        * noTriples([1, 1, 2, 2, 1]) → true
        * noTriples([1, 1, 2, 2, 2, 1]) → false
        * noTriples([1, 1, 1, 2, 2, 2, 1]) → false
        */
        public bool NoTriples(int[] nums)
        {
            int count = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                    if (count == 3)
                        return false;
                }
                else
                {
                    count = 1;
                }
            }
            return true;
        }
    }
}