using C_Sharp_Practice;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class SortTests
    {
        BubbleSort bubbleSort;

        public SortTests()
        {
            bubbleSort = new BubbleSort();
        }

        [Fact]
        public void Test_BubbleSortAsc()
        {
            var result = bubbleSort.SortAsc(new[] { 1, 659, 54, 69, 0 });
            var expectedAsc = new[] { 0, 1, 54, 69, 659 };
            Assert.Equal(expectedAsc, result);
        }

        [Fact]
        public void Test_BubbleSortDesc()
        {
            var result = bubbleSort.SortDesc(new[] { 1, 659, 54, 69, 0 });
            var expectedDesc = new[] { 659, 69, 54, 1, 0 };
            Assert.Equal(expectedDesc, result);
        }
    }
}
