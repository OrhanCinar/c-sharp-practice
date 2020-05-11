using C_Sharp_Practice.Searching;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Searching
{
    public class FibonacciSearchTest
    {
        FibonacciSearch search = new FibonacciSearch();

        [Fact]
        public void TestFibonacciSearch()
        {
            int[] arr = { 10, 22, 35, 40, 45, 50,
                    80, 82, 85, 90, 100 };
            int x = 85;
            int n = 11;

            var actual = search.Search(arr, x, n);
            var expected = 8;
            Assert.Equal(expected, actual);
        }
    }
}
