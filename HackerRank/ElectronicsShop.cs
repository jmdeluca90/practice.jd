using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class ElectronicsShop
    {
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maxCost = -1;
            // return -1 if budget does not cover can be simplified by just setting maxCost to -1 initially

            // also could just do a foreach check here
            // for (int i = 0; i < keyboards.Length; i++)
            foreach (int i in keyboards)
            {
                // for (int j = 0; j < drives.Length; j++)
                foreach (int j in drives)
                {
                    // int sum = keyboards[i] + drives[j];
                    int sum = i + j;
                    maxCost = sum > maxCost && sum <= b ? sum : maxCost;
                }
            }
            return maxCost;
        }
        public static int getMoneySpentUsingSortAndTwoPointer(int[] keyboards, int[] drives, int b)
        {
            Array.Sort(keyboards); // sort both ascending
            Array.Sort(drives);

            int maxCost = -1;
            int i = 0; // keyboard pointer (low to high)
            int j = drives.Length - 1; // drive pointer (high to low)

            while (i < keyboards.Length && j >= 0)
            {
                int sum = keyboards[i] + drives[j];

                if (sum > b)
                {
                    j--; // too expensive, need to move to a cheaper drive
                }
                else
                {
                    if (sum > maxCost)
                        maxCost = sum;

                    i++; // try a more expensive keyboard
                }
            }
            return maxCost;
        }
    }
}
