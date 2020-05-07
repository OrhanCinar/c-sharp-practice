using C_Sharp_Practice.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitTestProject.Searching
{
    public class InterpolationSearchTest
    {
        InterpolationSearch search = new InterpolationSearch();

        [Fact]
        public void TestInterpolationSearch()
        {
            int[] arr = {10, 12, 13, 16, 18,19, 20, 21, 22, 23,24, 33, 35, 42, 47 };

            arr = arr.OrderBy(c => c).ToArray();
            int x = 18;


            var actual = search.Search(arr, x);
            var expected = 4;
            Assert.Equal(expected, actual);
        }
    }
}
