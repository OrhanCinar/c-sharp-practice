using C_Sharp_Practice.Sorting;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class MergeSortTest
    {
        MergeSort mergeSort = new MergeSort();
        MergeSortIterative mergeSortIterative = new MergeSortIterative();

        [Fact]
        public void Test_MergeSort()
        {
            var arr = new[] { 12, 11, 13, 5, 6, 7 };

            var result = mergeSort.Sort(arr, 0, arr.Length - 1);
            var expected = new[] { 5, 6, 7, 11, 12, 13 };
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test_MergeSortIterative()
        {
            var arr = new[] { 12, 11, 13, 5, 6, 7 };

            var result = mergeSortIterative.Sort(arr,arr.Length);
            var expected = new[] { 5, 6, 7, 11, 12, 13 };
            Assert.Equal(expected, result);
        }

    }
}
