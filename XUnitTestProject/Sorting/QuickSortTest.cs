using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class QuickSortTest
    {
        QuickSort sort = new QuickSort();

        [Fact]
        public void TestQuickSort()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            var actual = sort.Sort(arr, 0, n - 1);
            var expected = new int[] { 1, 5, 7, 8, 9, 10 };
            Assert.Equal(expected, actual);
        }
    }
}
