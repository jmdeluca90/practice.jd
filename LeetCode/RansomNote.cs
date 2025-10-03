using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.LeetCode
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            // TRUE if ransomNote can be constructed by using the letters from magazine, otherwise FALSE
            // or another way to put it, can the letters from magazine construct the ransomNote
            if (magazine.Length < ransomNote.Length) return false;
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                char c = magazine[i];
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 1;
                }
                else
                {
                    dict[c] += 1;
                }
            }
            foreach (char c in ransomNote)
            {
                if (dict.GetValueOrDefault(c, 0) > 0)
                {
                    dict[c]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
