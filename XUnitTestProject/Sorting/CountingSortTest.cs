using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class CountingSortTest
    {

        CountingSort sort = new CountingSort();

        [Fact]
        public void Test_CountingSort()
        {
            char[] arr = {'g', 'e', 'e', 'k', 's', 'f', 'o','r', 'g', 'e', 'e', 'k', 's'};
            var actual = sort.Sort(arr);
            char[] expected = { 'e', 'e','e', 'e', 'f', 'g', 'g', 'k', 'k', 'o', 'r', 's', 's' };

            Assert.Equal(expected, actual);
        }
    }
}
