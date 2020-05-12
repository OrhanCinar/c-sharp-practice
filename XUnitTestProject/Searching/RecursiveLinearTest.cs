using C_Sharp_Practice.Searching;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Searching
{
    public class RecursiveLinearTest
    {
        RecursiveLinearSearch search = new RecursiveLinearSearch();

        [Fact]
        public void TestRecursiveLinearSearch()
        {
            int[] arr = { 2, 3, 4, 10, 40,6 };
            int x = 10;
            int n = arr.Length;

            var actual = search.Search(arr, 0, n - 1, x);
            var expected = 3;
            Assert.Equal(expected, actual);
        }
    }
}
