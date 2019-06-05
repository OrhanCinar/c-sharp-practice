using C_Sharp_Practice.Arrays;
using Xunit;

namespace XUnitTestProject.Arrays
{
    public class ArrayMoveZerosTest
    {
        ArrayMoveZeros _arrayMoveZeros = new ArrayMoveZeros();

        [Fact]
        public void Test_ArrayMoveZeros()
        {
            var arr = new[] { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
            int n = arr.Length;
            var result = _arrayMoveZeros.PushZerosToEnd(arr, n);
            var expected = new[] { 1, 9, 8, 4, 2, 7, 6, 9, 0, 0, 0, 0 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayMoveZeros2()
        {
            var arr = new[] { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
            int n = arr.Length;
            var result = _arrayMoveZeros.PushZerosToEnd(arr, n);
            var expected = new[] { 1, 9, 8, 4, 2, 7, 6, 9, 0, 0, 0, 0 };
            Assert.Equal(expected, result);
        }
    }
}
