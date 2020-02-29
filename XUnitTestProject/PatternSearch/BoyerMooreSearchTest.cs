using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class BoyerMooreSearchTest
    {
        BoyerMooreSearch boyerMooreSearch = new BoyerMooreSearch();

        [Fact]
        public void TestBoyerMooreSearch()
        {
            char[] txt = "ABAAABCD".ToCharArray();
            char[] pat = "ABC".ToCharArray();
            var actual = boyerMooreSearch.Search(txt, pat);
            var expected = 1;

            Assert.Equal(expected, actual.Count);
        }
    }
}
