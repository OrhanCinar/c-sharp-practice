using C_Sharp_Practice.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitTestProject.Searching
{
    public class ExponentialSearchTest
    {
        ExponentialSearch search = new ExponentialSearch();

        [Fact]
        public void TestExponentialSearch()
        {
            int[] arr = { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 };

            arr = arr.OrderBy(c => c).ToArray();
            int x = 18;
            int n = arr.Length;

            var actual = search.Search(arr, n, x);
            var expected = 4;
            Assert.Equal(expected, actual);
        }
    }
}
