using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class PancakeSortTest
    {
        PancakeSort sort = new PancakeSort();

        [Fact]
        public void TestPancakeSort()
        {
            int[] arr = { 3, 7, 4, 8, 6, 2, 1, 5 };
            int n = arr.Length;
    
            var actual = sort.Sort(arr, n);
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.Equal(expected, actual);
        }
    }
}
