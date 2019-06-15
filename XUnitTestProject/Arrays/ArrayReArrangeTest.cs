using C_Sharp_Practice.Arrays;
using Xunit;

namespace XUnitTestProject.Arrays
{
    public class ArrayReArrangeTest
    {
        ArrayReArrange _arrayReArrange = new ArrayReArrange();

        [Fact]
        public void Test_ArrayReArrange()
        {
            var arr = new[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };
            var result = _arrayReArrange.ReArrangeArray(arr);
            var expected = new[] { -1, 1, 2, 3, 4, -1, 6, -1, -1, 9 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayReArrange2()
        {
            var arr = new[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };
            var result = _arrayReArrange.ReArrangeArray2(arr);
            var expected = new[] { -1, 1, 2, 3, 4, -1, 6, -1, -1, 9 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayReArrangeSwap()
        {
            var arr = new[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };
            var result = _arrayReArrange.ReArrangeArraySwap(arr);
            var expected = new[] { -1, 1, 2, 3, 4, -1, 6, -1, -1, 9 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ReArrangePositiveNegative()
        {
            var arr = new[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 };

            int n = arr.Length;

            var result = _arrayReArrange.ReArrangePositiveNegative(arr, n);
            var expected = new[] { 4, -3, 5, -1, 6, -7, 2, 8, 9 };
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test_ReArrangePositiveNegativeAlternate()
        {
            var arr = new[] { -5, -2, 5, 2, 4, 7, 1, 8, 0, -8 };

            int n = arr.Length;

            var result = _arrayReArrange.ReArrangePositiveNegativeAlternate(arr, n);
            var expected = new[] { -5, 5, -2, 2, -8, 4, 7, 1, 8, 0 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ReArrangeEvens()
        {
            var arr = new[] { 1, 3, 2, 2, 5 };

            int n = arr.Length;

            var result = _arrayReArrange.ReArrangeEvens(arr, n);
            var expected = new[] { 1, 5, 2, 3, 2 };
            Assert.Equal(expected, result);
        }

    }
}
