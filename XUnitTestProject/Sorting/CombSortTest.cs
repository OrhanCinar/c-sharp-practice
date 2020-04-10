using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class CombSortTest
    {

        CombSort sort = new CombSort();

        [Fact]
        public void Test_CombSort()
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
                    var actual = sort.Sort(arr);
            int[] expected = { 2, 24, 45, 66, 75, 90, 170, 802 };

            Assert.Equal(expected, actual);
        }
    }
}
