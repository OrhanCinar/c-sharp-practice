using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class ShellSortTest
    {

        ShellSort sort = new ShellSort();

        [Fact]
        public void Test_ShellSort()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
                    var actual = sort.Sort(arr);
            int[] expected = { 2, 24, 45, 66, 75, 90, 170, 802 };

            Assert.Equal(expected, actual);
        }
    }
}
