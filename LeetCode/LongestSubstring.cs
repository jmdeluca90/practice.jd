using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.LeetCode
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int l = s.Length;
            if (l == 0) return 0;
            var dict = new Dictionary<char, int>();
            int maxLength = 0, start = 0;

            for (int end = 0; end < l; end++)
            {
                char c = s[end];
                if (dict.ContainsKey(c))
                {
                    start = Math.Max(dict[c] + 1, start);
                }
                dict[c] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            return maxLength;
        }
    }
}