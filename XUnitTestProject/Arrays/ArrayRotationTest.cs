using C_Sharp_Practice.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Arrays
{
    public class ArrayRotationTest
    {

        ArrayRotation _arrayRotation = new ArrayRotation();

        [Fact]
        public void Test_BubbleSortAsc()
        {
            var result = _arrayRotation.ArrayRoration1(new[] { 1, 2, 3, 4, 5, 6, 7 },2,7);
            var expectedAsc = new[] { 3, 4, 5, 6, 7, 1, 2 };
            Assert.Equal(expectedAsc, result);
        }
    }
}
