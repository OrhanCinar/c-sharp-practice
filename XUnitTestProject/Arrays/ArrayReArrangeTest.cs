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
            var result = _arrayReArrange.ReArrangeArraySwap(new[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 });
            var expected = new[] { -1, 1, 2, 3, 4, -1, 6, -1, -1, 9 };
            Assert.Equal(expected, result);
        }
    }
}
