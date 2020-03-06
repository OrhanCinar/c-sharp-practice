using C_Sharp_Practice;
using C_Sharp_Practice.Sorting;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class InsertionSortTest
    {
        InsertionSort insertionSort = new InsertionSort();


        [Fact]
        public void TestInsertionSort()
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            var result = insertionSort.Sort(arr);
            var expected = new[] { 5, 6, 11, 12, 13 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestInsertionSortRecursive()
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            var result = insertionSort.SortRecursive(arr, arr.Length);
            var expected = new[] { 5, 6, 11, 12, 13 };
            Assert.Equal(expected, result);
        }
    }
}
