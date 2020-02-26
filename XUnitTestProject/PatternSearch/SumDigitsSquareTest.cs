using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class SumDigitsSquareTest
    {
        SumDigitsSquare sumDigitsSquare = new SumDigitsSquare();

        [Fact]
        public void TestSumDigitsSquare()
        {
            string s = "1111";
            var expected = 16;
            var actual = sumDigitsSquare.SquareDigitSum(s);

            Assert.Equal(expected, actual);
        }
    }
}
