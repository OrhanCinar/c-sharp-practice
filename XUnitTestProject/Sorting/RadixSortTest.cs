using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class RadixSortTest
    {

        RadixSort sort = new RadixSort();

        [Fact]
        public void Test_RadixSort()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            int n = arr.Length;
            var actual = sort.RadixSorting(arr, n);
            int[] expected = { 2, 24, 45, 66, 75, 90, 170, 802 };

            Assert.Equal(expected, actual);
        }
    }
}
