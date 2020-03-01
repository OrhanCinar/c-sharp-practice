using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class BoyerMooreGoodSuffixTest
    {

        BoyerMooreGoodSuffix boyerMooreGoodSuffix = new BoyerMooreGoodSuffix();

        [Fact]
        public void TestBoyerMooreGoodSuffix()
        {

            char[] text = "ABAAAABAACD".ToCharArray();
            char[] pat = "ABA".ToCharArray();
            var actual = boyerMooreGoodSuffix.Search(text, pat);
            var expected = 2;

            Assert.Equal(expected, actual.Count);

        }
    }
}
