using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class APCICPCTeam
    {
        public static List<int> acmTeam(List<string> topic)
        {
            int n = topic.Count;
            int max = 0;
            int teamMax = 0;
            // returns a list of int - max topics and # of teams that know that many topics
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    // int a = Convert.ToInt32(topic[i], 2);
                    // int b = Convert.ToInt32(topic[j], 2);
                    // int combined = a | b;
                    // int current = CountBits(combined);
                    int current = 0;
                    for (int k = 0; k < topic[i].Length; k++)
                    {
                        if (topic[i][k] == '1' || topic[j][k] == '1')
                            current++;
                    }
                    if (current > max)
                    {
                        max = current;
                        teamMax = 1;
                    }
                    else if (current == max)
                    {
                        teamMax++;
                    }
                }
            }
            return new List<int> { max, teamMax };
        }
        public static int CountBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                    count++;
                n >>= 1;
            }
            return count;
        }
    }
}
