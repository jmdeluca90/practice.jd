using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.LeetCode
{
    public class IsValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            string newString = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    newString += char.ToLower(c);
                }
            }
            if (newString == String.Empty) { return true; }
            int left = 0, right = newString.Length - 1;
            while (left < right)
            {
                if (newString[left++] != newString[right--]) return false;
            }
            return true;

        }
    }
}
