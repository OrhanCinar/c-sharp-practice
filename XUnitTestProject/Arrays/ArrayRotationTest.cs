using C_Sharp_Practice.Arrays;
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
        ArrayRotationFindMaxSum _arrayRotationFindMaxSum = new ArrayRotationFindMaxSum();
        ArrayRotationCount _arrayRotationCount = new ArrayRotationCount();
        ArrayRotationMultiply _arrayRotationMultiply = new ArrayRotationMultiply();
        ArrayRotationMultiplyOptimized _arrayRotationMultiplyOptimized = new ArrayRotationMultiplyOptimized();
        ArrayMinimumElementSorted _arrayMinimumElementSorted = new ArrayMinimumElementSorted();
        ArrayRightRotation _arrayRightRotation = new ArrayRightRotation();

        [Fact]
        public void Test_ArrayRoration1()
        {
            var result = _arrayRotation.ArrayRoration1(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 7);
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
            var result = _arrayRotationCyclically.RotateArray(new[] { 1, 2, 3, 4, 5 });
            var expected = new[] { 5, 1, 2, 3, 4 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_CheckArrayPairSum()
        {
            var result = _arrayPairSum.CheckArrayPairSum(new[] { 11, 15, 6, 8, 9, 10 }, 16);

            Assert.True(result);
        }

        [Fact]
        public void Test_ArrayRotationFindMaxSum()
        {
            var result = _arrayRotationFindMaxSum.GetMaxSum(new[] { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Assert.Equal(330, result);
        }

        [Fact]
        public void Test_ArrayRotationFindMaxSum2()
        {
            var result = _arrayRotationFindMaxSum.GetMaxSum2(new[] { 8, 3, 1, 2 });

            Assert.Equal(29, result);
        }

        [Fact]
        public void Test_ArrayRotationCount()
        {
            var result = _arrayRotationCount.GetRotationCount(new[] { 15, 18, 2, 3, 6, 12 });

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_ArrayRotationCountWithBinaryTree()
        {
            var arr = new[] { 15, 18, 2, 3, 6, 12 };
            int n = arr.Length;

            var result = _arrayRotationCount.GetRotationCountWithBinaryTree(arr, 0, n - 1);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_ArrayRotationMultiply()
        {           
            var result = _arrayRotationMultiply.GetArraysRotations(new[] { 1, 3, 5, 7, 9 });

            Assert.True(result);
        }

        [Fact]
        public void Test_ArrayRotationMultiplyOptimized()
        {           
            var result = _arrayRotationMultiplyOptimized.GetArraysRotations(new[] { 1, 3, 5, 7, 9 });

            Assert.True(result);
        }

        [Fact]
        public void Test_ArrayMinimumElementSorted()
        {
            var arr = new[] { 5, 6, 1, 2, 3, 4 };
            int n = arr.Length;

            var result = _arrayMinimumElementSorted.FindMin(arr, 0, n - 1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_ArrayRightRotation()
        {
            var arr = new[] { 1, 2, 3, 4, 5,6, 7, 8, 9, 10 };
            int k = 3; // rotation count
            int n = arr.Length;
            var expected = new[] { 8, 9, 10,1, 2, 3, 4, 5, 6, 7 };

            var result = _arrayRightRotation.RightRotate(arr, k, n);

            Assert.Equal(expected, result);
        }
    }
}
