using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class LongestIncreasingSubsequenceTest
    {
        LongestIncreasingSubsequence longestIncreasingSubsequence = new LongestIncreasingSubsequence();
        LongestIncreasingSubsequenceLongestCommon longestIncreasingSubsequence2 = new LongestIncreasingSubsequenceLongestCommon();

        [Fact]
        public void TestLongestIncreasingSubsequence()
        {
           
            List<int> sequence = new List<int>
            {
                12,
                34,
                1,
                5,
                40,
                80
            };

            var actual = longestIncreasingSubsequence.Search(sequence);
            Assert.Equal(4, actual);
        }

        [Fact]
        public void TestLongestIncreasingSubsequenceLongestCommon()
        {

            List<int> sequence = new List<int>
            {
                12,
                34,
                1,
                5,
                40,
                80
            };

            var actual = longestIncreasingSubsequence2.Search(sequence);
            Assert.Equal(4, actual);
        }
        

    }
}
