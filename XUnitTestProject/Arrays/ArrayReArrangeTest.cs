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
            var result = _arrayReArrange.ReArrangeArray(new[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 });
            var expected = new[] { -1, 1, 2, 3, 4, -1, 6, -1, -1, 9 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayReArrange2()
        {
            var result = _arrayReArrange.ReArrangeArray2(new[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 });
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
    }
}
