using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class JayingOnCs
    {
        public static int jumpingOnClouds(int[] c, int k)
        {
            int e = 100; 
            int n = c.Length;
            int currentIndex = 0;

            while (e > 0)
            {
                currentIndex = (currentIndex + k) % n; // set the index to current value + value of the jump % n
                e--; // base energy being used

                if (c[currentIndex] == 1) // if we land on thundercloud
                    e -= 2;
                if (currentIndex == 0) // if we loop back to zero we return e energy
                    return e;
            }
            return e;

        }
    }
}
