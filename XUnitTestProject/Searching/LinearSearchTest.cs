using C_Sharp_Practice.Searching;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Searching
{
    public class LinearSearchTest
    {
        LinearSearch search = new LinearSearch();

        [Fact]
        public void TestLinearSearch()
        {
            int[] arr = { 3, 7, 4, 8, 6, 2, 1, 5 };
            int x = 2;
            var actual = search.Search(arr, x);
            var expected = 5;
            Assert.Equal(expected, actual);
        }
    }
}
