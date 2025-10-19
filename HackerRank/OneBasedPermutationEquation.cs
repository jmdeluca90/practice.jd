using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    internal class OneBasedPermutationEquation
    {
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> result = [];
            int n = p.Count;
            for (int i = 1; i <= n; i++)
            {
                int p2 = p.IndexOf(i);
                int p3 = p.IndexOf(p2 + 1);
                result.Add(p3 + 1);
            }
            return result;
        }
    }
}
