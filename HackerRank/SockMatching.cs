using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.HackerRank
{
    public class SockMatching
    {
        // this one was easy but could probably be optimized - solution: O(n) time and O(k) space where k = # of unique colored socks
        public static int SockMerchant(int n, List<int> ar)
        {
            int pairs = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int sock in ar)
            {
                dict.TryAdd(sock, 0);
                dict[sock]++;
            }

            foreach (int color in dict.Keys)
            {
                pairs += dict[color] / 2;
            }
            return pairs;
        }
        // yep this can definitely be optimized to only loop throughthe dictionary once - solution: still O(n) time and O(k) space, but only loop once through dictionary
        public static int SockMerchantOptimized(int n, List<int> ar)
        {
            int pairs = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int sock in ar)
            {
                if (dict.ContainsKey(sock))
                {
                    dict[sock]++;
                    if (dict[sock] % 2 == 0)
                        pairs++;
                }
                else
                {
                    dict[sock] = 1;
                }
            }
            return pairs;
        }
        // but what if we could optimize even more? constraints tell us that n (# of socks) will be between 1-100 and ar[i] (colors of sock) will be between 0-99
        // with that in mind, we can use an array to solve the problem with O(n) time and O(1) space
        public static int SockMerchantOptimizedWithArray(int n, List<int> ar)
        {
            int pairs = 0;
            int[] arr = new int[101];

            foreach (int sock in ar)
            {
                    arr[sock]++;
                    if (arr[sock] % 2 == 0)
                        pairs++;
            }
            return pairs;
        }
    }
}
