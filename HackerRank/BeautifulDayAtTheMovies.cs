using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class BeautifulDayAtTheMovies
    {
        public static int beautifulDays(int i, int j, int k)
        {
            int bdCount = 0;
            int count = j - i + 1;
            int[] days = Enumerable.Range(i, count).ToArray();

            foreach (int day in days)
            {
                int reverse = int.Parse(new string(day.ToString().Reverse().ToArray()));
                if (Math.Abs(day - reverse) % k == 0)
                    bdCount++;
            }
            return bdCount;
        }
        public static int beautifulDaysLINQSolution(int i, int j, int k)
        {
            int beautifulDays = Enumerable
                .Range(i, j - i + 1)
                .Count(day => Math.Abs(day - int.Parse(new string(day.ToString().Reverse().ToArray()))) % k == 0);

            return beautifulDays;
        }
    }
}
