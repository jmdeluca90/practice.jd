using System;

public class TwoSum
{
    public int[] TwoSumSolution(int[] nums, int target)
    {
        // example nums = [2,7,11,15], target = 9
        Dictionary<int, int> numberToIndex = new Dictionary<int, int>(); // create dictionary to store number and its index

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i]; // find complement by subtracting number at current position from the target
            if (numberToIndex.ContainsKey(complement)) // check if complement exists in dictionary
            {
                return new int[] { numberToIndex[complement], i }; // if it does, return the index of the complement and the current index
            }
            if (!numberToIndex.ContainsKey(nums[i])) // only add number if it doesn't already exist in dictionary
            {
                numberToIndex[nums[i]] = i; // add number and its index to dictionary (e.g.  numberToIndex[2] = 0
            }
        }
        throw new ArgumentException("No two sum solution");
    }

}
