using C_Sharp_Practice;
using C_Sharp_Practice.Sorting;
using Xunit;

namespace XUnitTestProject.Sorting
{
    public class BucketSortTest
    {
        BucketSort sort = new BucketSort();

        [Fact]
        public void Test_BucketSort()
        {
            int[] arr = new int[] { -1, 25, -58964, 8547, -119, 0, 78596 };

            var result = sort.Sort(arr, arr.Length - 1);
            int[] expectedAsc = {-58964,-119,-1,0,25,8547,78596 };
            Assert.Equal(expectedAsc, result);
        }


    }
}
