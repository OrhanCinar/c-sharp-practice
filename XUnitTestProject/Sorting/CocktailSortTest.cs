using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class CocktailSortTest
    {
        CocktailSort sort = new CocktailSort();

        [Fact]
        public void TestCocktailSort()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            var actual = sort.Sort(arr);
            var expected = new int[] { 1, 5, 7, 8, 9, 10 };
            Assert.Equal(expected, actual);
        }
    }
}
