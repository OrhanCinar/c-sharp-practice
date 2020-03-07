using C_Sharp_Practice.Sorting;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class MergeSortTest
    {
        MergeSort mergeSort = new MergeSort();

        [Fact]
        public void Test_MergeSort()
        {
            var arr = new[] { 12, 11, 13, 5, 6, 7 };

            var result = mergeSort.Sort(arr, 0, arr.Length - 1);
            var expected = new[] { 5, 6, 7, 11, 12, 13 };
            Assert.Equal(expected, result);
        }

    }
}
