namespace LeetCode.TopInterview150;

public class MergeSortedArray88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            return;
        }
        
        var mPointer = m - 1;
        var nPointer = n - 1;
        var end = m + n - 1;

        while (mPointer >= 0 && nPointer >= 0)
        {
            if (nums1[mPointer] > nums2[nPointer])
            {
                nums1[end] = nums1[mPointer];
                mPointer--;
            }
            else
            {
                nums1[end] = nums2[nPointer];
                nPointer--;
            }

            end--;
        }

        // while (nPointer >= 0)
        // {
        //     nums1[end] = nums2[nPointer];
        //     nPointer--;
        //     end--;
        // }
        if (nPointer >= 0)
        {
            Array.Copy(nums2, 0, nums1, 0,  nPointer + 1);    
        } 
    }
}