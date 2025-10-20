using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class AppendAndDelete
    {
        public static string appendAndDelete(string s, string t, int k)
        {
            int sCount = s.Length, tCount = t.Length;
            int opCount = 0;

            for (int i = 0; i < Math.Min(sCount, tCount); i++)
            {
                if (s[i] == t[i])
                {
                    opCount++;
                }
                else break;
            }
            int totalOps = (sCount - opCount) + (tCount - opCount);

            if (totalOps > k)
                return "No";
            else if ((k - totalOps) % 2 == 0 || k >= sCount + tCount)
                return "Yes";
            else
                return "No";
        }
    }
}
