using C_Sharp_Practice.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Arrays
{
    public class ArraySwapTests
    {


        ArraySwap _arraySwap = new ArraySwap();

        [Fact]
        public void Test_ArrayMoveZeros()
        {
            var arr = new[] { 2, 1, 5, 6, 3 };
            int n = arr.Length;
            int k = 3;

            var result = _arraySwap.GetMinSwap(arr, n, k);
            var expected = 1;
            Assert.Equal(expected, result);
        }
    }
}
