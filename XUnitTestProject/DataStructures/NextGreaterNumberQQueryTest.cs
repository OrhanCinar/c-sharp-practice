using System;
using System.Collections.Generic;
using System.Text;
using C_Sharp_Practice.DataStructures;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class NextGreaterNumberQQueryTest
    {
        NextGreaterNumberQQuery nextGreaterNumberQQuery = new NextGreaterNumberQQuery();

        [Fact]
        public void Test_NextGreaterNumberQQuery()
        {

            int[] arr = new int[] { 3, 4, 2, 7, 5, 8, 10, 6 };
            int[] query = new int[] { 3, 6, 1 };
            int[] ans = nextGreaterNumberQQuery.Query(arr, query);

            var expected = new int[] { 8, -1, 7 };
            var actual = new int[expected.Length];
            for (int i = 0; i < query.Length; i++)
            {
                actual[i] = ans[query[i]];
            }

            Assert.Equal(expected, actual);
        }
    }
}
