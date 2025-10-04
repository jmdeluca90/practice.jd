using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.jd.LeetCode
{
    public class RemoveDupFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var count = 1;
            var writenIndex = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count <= 2)
                {
                    nums[writenIndex] = nums[i];
                    writenIndex++;
                }

            }
            return writenIndex;
        }
    }
}
