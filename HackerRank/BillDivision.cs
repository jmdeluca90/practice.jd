using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class BillDivision
    {
        // this problem asks us to take a list of n integer items on a bill, add them all besides the one at index k, and then determine whether the bill is split evenly
        // b is the portion that the other person was charged - if it is more than half of the sumOfItems - bill[k], print the amount that was overcharged
        // if everyone paid their fair share, print "Bon Appetit"
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            string bonApp = "Bon Appetit";
            int n = bill.Count;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                // only add to total when i != k
                if (i != k)
                    total += bill[i];
                // this part can be simplified
                // total += bill[i];
                // if (k == i) { total -= bill[i]; }
            }

            int half = total / 2; // can also call this variable "fairShare" *sigh*

            if (b == half)
                Console.WriteLine(bonApp);
            else
                Console.WriteLine(b - half);
        }
    }
}
