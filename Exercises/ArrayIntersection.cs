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
        CHALLENGE: Using array A and array B, return an array that is the intersection of both A and B.
        The intersection includes numbers that appear in both arrays.

            ArrayIntersection([1, 3, 5], [1, 5, 7]) → [1, 5]
            ArrayIntersection([1], [1, 5, 7]) → [1]
            ArrayIntersection([1, 1, 1], [1, 5, 7]) → [1]
            ArrayIntersection([], []) → []
        */
        public int[] ArrayIntersection(int[] a, int[] b)
        {
           HashSet <int> commonElements = new HashSet<int>();
            for (int i=0;i<a.Length;i++)
            {
                for (int j=0;j<b.Length;j++)
                {
                    if (a[i] == b[j])
                        commonElements.Add(a[i]);
                }
            }
            return commonElements.ToArray();
        }
    }
}
