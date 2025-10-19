using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class HurdleRace
    {
        public static int hurdleRace(int k, List<int> height)
        {
            // this is O(n log n) because we have to sort
            height.Sort(); height.Reverse(); // sort the list and put it in asc order

            if (k >= height[0])
            {
                return 0;
            }
            return height[0] - k;
        }
        public static int hurdleRaceOptimized(int k, List<int> height)
        {
            int maxHurdle = height.Max();

            if (k >= maxHurdle)
            {
                return 0;
            }
            return maxHurdle - k;
        }
        public static int hurdleRaceOptimizedMoBetta(int k, List<int> height)
        {
            int maxHurdle = height.Max();

            return Math.Max(0, maxHurdle - k);
        }
    }
}
