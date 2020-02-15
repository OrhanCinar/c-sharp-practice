using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class NaivePatternSearchTest
    {
        NaivePatternSearch naivePatternSearch = new NaivePatternSearch();

        [Fact]
        public void TestNaiveSearch()
        {
            string text = "AABAACAADAABAAABAA";
            string pat = "AABA";
            var actual = naivePatternSearch.NaiveSearch(text, pat);

            Assert.Equal(3, actual.Count);
        }

    }
}
