using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class SelectionSortTest
    {
        SelectionSort selectionSort = new SelectionSort();

        [Fact]
        public void TestSelectionSort()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            var actual = selectionSort.Sort(arr);
            var expected = new int[] { 11, 12, 22, 25, 64 };
            Assert.Equal(expected, actual);
        }
    }
}
