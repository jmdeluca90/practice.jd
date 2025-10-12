using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class BirthdayChocolates
    {
        // this is a problem where 2 people want to share a chocolate bar; each of the n squares has an integer on it (s[n] = # on each chocolate)
        // chocolate is shared if a contiguous segment of the bar -  length = persons birth month (d) and sum of the integers on that segment == birth month
        public static int birthday(List<int> s, int d, int m)
        {
            // this is likely a 2 pointer, where one of the pointers will be the length of birth month
            // nope JK this is a sliding window

            int result = 0;
            for (int n = 0; n <= s.Count - m; n++)
            {
                int bd = 0;
                for (int i = n; i < n + m; i++)
                {
                    bd += s[i];
                }
                if (bd == d) { result++; }
            }
            return result;
        }
    }
}
