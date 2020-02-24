using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class MinGivenOperationConvertBinaryTest
    {

        MinGivenOperationConvertBinary minGivenOperation = new MinGivenOperationConvertBinary();

        [Fact]
        public void Test_MinGivenOperationConvertBinary()
        {
            string str = "10010111";
            var actual = minGivenOperation.Convert(str);
            var expected = 5;

            Assert.Equal(expected, actual);
        }
    }
}
