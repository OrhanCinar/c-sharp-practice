using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class HeapSortTest
    {
        HeapSort sort = new HeapSort();

        [Fact]
        public void TestHeapSort()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };

            var actual = sort.Sort(arr);
            var expected = new int[] { 5, 6, 7, 11, 12, 13 };
            Assert.Equal(expected, actual);
        }
    }
}
