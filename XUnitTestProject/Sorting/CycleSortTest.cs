using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class CycleSortTest
    {
        CycleSort sort = new CycleSort();

        [Fact]
        public void TestCycleSort()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            var actual = sort.Sort(arr, n);
            var expected = new int[] { 1, 5, 7, 8, 9, 10 };
            Assert.Equal(expected, actual);
        }
    }
}
