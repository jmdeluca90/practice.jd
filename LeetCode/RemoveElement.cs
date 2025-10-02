using practice.jd.Helpers;
public class RemoveElement
{
    public int RemoveElementSolution(int[] nums, int val)
    {
        int i = 0;
        int n = nums.Length;

        while (i < n)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[n - 1]; //Replace current element w last element
                n--; //Reduce size of length (so we can compare last element with second to last element)
            }
            else
            {
                i++;// Only move forward if current element is kept
            }

        }
        return n; // n is the count of elements not equal to val
    }
}