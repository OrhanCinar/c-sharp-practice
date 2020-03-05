using C_Sharp_Practice;
using C_Sharp_Practice.Sorting;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class BubbleSortRecursiveTest
    {
        BubbleSortRecursive bubbleSort = new BubbleSortRecursive();


        [Fact]
        public void TestBubbleSortRecursive()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            var result = bubbleSort.Sort(arr, arr.Length);
            var expected = new[] { 11, 12, 22, 25, 34, 64, 90 };
            Assert.Equal(expected, result);
        }
    }
}
