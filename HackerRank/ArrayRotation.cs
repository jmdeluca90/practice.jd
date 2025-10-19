using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    // in this code we have an array int[] a, an int k that represents the number of times to rotate to the right
    // we also have an array int[] queries - these are the index positions to return after rotation
    public class ArrayRotation
    {
        public static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
        {
            List<int> result = [];
            int n = a.Count; // get count of the array to rotate
            k %= n; // normalize the amount of rotations in case its longer than the count - in that case we need to wrap around to beginning
            foreach (int q in queries)
            {
                int og = (q - k + n) % n; // to find the original index we subtract k from the index position we're looking for, then add n, then modulo n
                result.Add(a[og]);
            }

            return result;
        }
    }
}
