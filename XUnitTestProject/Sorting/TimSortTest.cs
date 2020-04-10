using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class TimSortTest
    {

        TimSort sort = new TimSort();

        [Fact]
        public void Test_TimSort()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            int n = arr.Length;
            var actual = sort.Sort(arr, n);
            int[] expected = { 2, 24, 45, 66, 75, 90, 170, 802 };

            Assert.Equal(expected, actual);
        }
    }
}
