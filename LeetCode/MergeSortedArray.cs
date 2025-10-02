using System;

public class MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // this is a comment - nums1 = m + n; nums2 = n; goal is to modify nums1 and sort into single array in non-decreasing order - they can be equal but next number can't be less
        int p1 = m - 1;
        int p2 = n - 1;
        int p = (m + n) - 1;

        while (p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] > nums2[p2])
            {
                nums1[p] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }

        // copy remaining elements in nums2
        while (p2 >= 0)
        {
            nums1[p] = nums2[p2];
            p2--;
            p--;
        }
    }

}