using C_Sharp_Practice.Arrays;
using Xunit;

namespace XUnitTestProject.Arrays
{
    public class ArrayReverseTest
    {
        [Fact]
        public void Test_ArrayReverse()
        {
            var arrayReverse = new ArrayReverse();

            var result = arrayReverse.ReverseArray(new[] { 1, 2, 3, 4, 5, 6 }, 0, 5);
            var expected = new[] { 6, 5, 4, 3, 2, 1 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_ArrayReverseRecursive()
        {
            var arrayReverse = new ArrayReverse();

            var result = arrayReverse.ReverseArrayRecursive(new[] { 1, 2, 3, 4, 5, 6 }, 0, 5);
            var expected = new[] { 6, 5, 4, 3, 2, 1 };
            Assert.Equal(expected, result);
        }
    }
}
