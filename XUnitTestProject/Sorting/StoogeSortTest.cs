using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class StoogeSortTest
    {
        StoogeSort sort = new StoogeSort();

        [Fact]
        public void TestStoogeSort()
        {
            int[] arr = { 3, 7, 4, 8, 6, 2, 1, 5 };
            int n = arr.Length;
            var actual = sort.Sort(arr, 0, n - 1);
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.Equal(expected, actual);
        }
    }
}
