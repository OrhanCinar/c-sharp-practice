using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class FiniteAutomataTest2
    {
        FiniteAutomata2 finiteAutomata = new FiniteAutomata2();

        [Fact]
        public void TestFiniteAutomata()
        {
            char[] txt = "GEEKS FOR GEEKS".ToCharArray();
            char[] pat = "GEEKS".ToCharArray();
         


            var actual = finiteAutomata.Search(pat,txt);
            var expected = 2;

            Assert.Equal(expected, actual.Count);
        }


    }
}
