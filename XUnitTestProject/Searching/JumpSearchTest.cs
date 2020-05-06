using C_Sharp_Practice.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitTestProject.Searching
{
    public class JumpSearchTest
    {
        JumpSearch search = new JumpSearch();

        [Fact]
        public void TestJumpSearch()
        {
            int[] arr = {0, 1, 1, 2, 3, 5, 8, 13, 21,
                    34, 55, 89, 144, 233, 377, 610 };

            arr = arr.OrderBy(c => c).ToArray();
            int x = 55;


            var actual = search.Search(arr, x);
            var expected = 10;
            Assert.Equal(expected, actual);
        }
    }
}
