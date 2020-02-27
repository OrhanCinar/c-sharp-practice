using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class FiniteAutomataTest
    {
        FiniteAutomata finiteAutomata = new FiniteAutomata();

        [Fact]
        public void TestFiniteAutomata()
        {
            char[] pat = "AABAACAADAABAAABAA".ToCharArray();
            char[] txt = "AABA".ToCharArray();

           

            var actual = finiteAutomata.Search(txt, pat);
            var expected = 3;

            Assert.Equal(expected, actual.Count);
        }


    }
}
