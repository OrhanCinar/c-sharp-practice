using System;
using System.Collections.Generic;
using System.Text;
using C_Sharp_Practice.DataStructures;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class MaximumProductOfIndexNGLRTest
    {
        MaximumProductOfIndexNGLR maximumProductOfIndexNGLR = new MaximumProductOfIndexNGLR();

        [Fact]
        public void Test_MaximumProductOfIndexNGLR()
        {
            int[] arr = new int[] { 5, 4, 3, 4, 5 };
            int n = arr.Length;
            var actual = maximumProductOfIndexNGLR.Search(arr, n);
            var expected = 8;
            Assert.Equal(expected, actual);
        }
    }
}
