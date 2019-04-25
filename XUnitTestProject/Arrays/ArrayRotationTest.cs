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
        ArrayRotationBlockSwap _arrayRotationBlock = new ArrayRotationBlockSwap();
        ArrayRotationReversal _arrayRotationReversal = new ArrayRotationReversal();
        ArrayRotationCyclically _arrayRotationCyclically = new ArrayRotationCyclically();
        ArrayPairSum _arrayPairSum = new ArrayPairSum();

        [Fact]
        public void Test_ArrayRoration1()
        {
            var result = _arrayRotation.ArrayRoration1(new[] { 1, 2, 3, 4, 5, 6, 7 },2,7);
            var expected = new[] { 3, 4, 5, 6, 7, 1, 2 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayRoration2()
        {
            var result = _arrayRotation.ArrayRoration2(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 7);
            var expected = new[] { 3, 4, 5, 6, 7, 1, 2 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayRoration3()
        {
            var result = _arrayRotation.ArrayRoration3(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 7);
            var expected = new[] { 3, 4, 5, 6, 7, 1, 2 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayRorationBlockSwap()
        {
            var result = _arrayRotationBlock.ArrayRoration(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 7);
            var expected = new[] { 3, 4, 5, 6, 7, 1, 2 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayRotationReversal()
        {
            var result = _arrayRotationReversal.ReverseArray(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 7);
            var expected = new[] { 3, 4, 5, 6, 7, 1, 2 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayRotationCyclically()
        {
            var result = _arrayRotationCyclically.RotateArray(new[] { 1, 2, 3, 4, 5});
            var expected = new[] { 5, 1, 2, 3, 4 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_CheckArrayPairSum()
        {
            var result = _arrayPairSum.CheckArrayPairSum(new[] { 11, 15, 6, 8, 9, 10 },16);
            
            Assert.Equal(true, result);
        }
    }
}
