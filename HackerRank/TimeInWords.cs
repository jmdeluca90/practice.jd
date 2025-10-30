using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class TimeInWords
    {
        public static string ToimeInWords(int h, int m)
        {
            // set up dictionary with values to map int to correct string phrasing for problem
            var dict = new Dictionary<int, string>()
            {
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine",
                [10] = "ten",
                [11] = "eleven",
                [12] = "twelve",
                [13] = "thirteen",
                [14] = "fourteen",
                [15] = "quarter",
                [16] = "sixteen",
                [17] = "seventeen",
                [18] = "eighteen",
                [19] = "nineteen",
                [20] = "twenty",
                [30] = "half"
            };
            for (int i = 21; i < 30; i++)
                dict[i] = "twenty " + dict[i - 20];

            if (m == 0)
            {
                return $"{dict[h]} o' clock"; // "hour" o' clock
            }
            else if (m == 15 || m == 30)
            {
                return $"{dict[m]} past {dict[h]}";
            }
            else if (m == 45)
            {
                return $"quarter to {dict[h + 1]}";
            }
            else if (m <= 30)
            {
                string minuteWord = m == 1 ? "minute" : "minutes";
                return $"{dict[m]} {minuteWord} past {dict[h]}"; // __ minutes "past" hour
            }
            else
            {
                int remainder = 60 - m;
                string minuteWord = remainder == 1 ? "minute" : "minutes";
                return $"{dict[remainder]} {minuteWord} to {dict[h + 1]}"; // ___ minutes "to" hour
            }
        }
    }
}
