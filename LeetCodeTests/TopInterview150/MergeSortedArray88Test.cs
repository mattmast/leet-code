namespace LeetCodeTests.TopInterview150;

public class MergedSortedArray88Test
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new [] { 1, 2, 3, 0, 0, 0, 0 }, 3, new [] { 2, 5, 6, 7 }, 4, ExpectedResult = new [] {1,2,2,3,5,6, 7})]
    [TestCase(new [] { 2, 5, 6, 7, 0, 0, 0 }, 4, new [] { 1, 2, 3, }, 3, ExpectedResult = new [] {1,2,2,3,5,6, 7})]
    [TestCase(new [] { 4,5,6,0,0,0 }, 3, new [] { 1, 2, 3, }, 3, ExpectedResult = new [] {1,2,3,4,5, 6})]
    [TestCase(new [] { 1 }, 1, new int[0], 0, ExpectedResult = new [] {1})]
    [TestCase(new [] { 0 }, 0, new [] { 1 }, 1, ExpectedResult = new [] {1})]
    public int[] TestIt(int[] nums1, int m, int[] nums2, int n)
    {
        (new LeetCode.TopInterview150.MergeSortedArray88()).Merge(nums1, m, nums2, n);
        return nums1;
    }
}