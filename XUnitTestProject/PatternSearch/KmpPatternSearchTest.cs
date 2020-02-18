using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class KmpPatternSearchTest
    {
        KmpAlgorithm kmpSearch = new KmpAlgorithm();

        [Fact]
        public void TestKMPSearch()
        {
            string text = "ABABDABACDABABCABAB";
            string pat = "ABABCABAB";
            var actual = kmpSearch.KmpAlgorithmSearch(text, pat);

            Assert.Equal(1, actual.Count);
        }

    }
}
