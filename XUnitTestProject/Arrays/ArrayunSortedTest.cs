using C_Sharp_Practice.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Arrays
{
    public class ArrayunSortedTest
    {
        ArrayUnsorted arrayUnsorted = new ArrayUnsorted();

        [Fact]
        public void Test_FindKSmallestElement()
        {
            int[] arr = new int[] { 12, 3, 5, 7, 19 };
            var actual = arrayUnsorted.FindKSmallestElement(arr, 2);
            Assert.Equal(5, actual);
        }

        [Fact]
        public void Test_FindKSmallestElementOptimized()
        {
            int[] arr = new int[] { 12, 3, 5, 7, 4, 19, 26 };
            int k = 3;
            var actual = arrayUnsorted.FindKSmallestElementOptimized(arr, 0, arr.Length - 1, k);
            Assert.Equal(5, actual);
        }


        [Fact]
        public void Test_FindKSmallestElement2()
        {
            int[] arr = new int[] { 12, 3, 5, 7, 4, 19, 26 };
            int k = 3;
            var actual = arrayUnsorted.FindKSmallestElementOptimized(arr, 0, arr.Length - 1, k);
            Assert.Equal(5, actual);
        }
    }
}
