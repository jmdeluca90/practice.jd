using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.LeetCode
{
    public class LongestCommonPrefixInStringArray
    {
        public string LongestCommonPrefixHorizontal(string[] strs)
        {
            // horizontal scanning
             string common = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(common) != 0)
                {
                    common = common.Substring(0, common.Length - 1);
                    if (common == "") return "";
                }
            }
            return common;
        }
        public string LongestCommonPrefixVertical(string[] strs)
        {
            // vertical scanning
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    }
}
