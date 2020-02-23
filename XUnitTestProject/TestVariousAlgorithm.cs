using C_Sharp_Practice;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Various
{
    public class TestVariousAlgorithm
    {
        VariousAlgorithm _variousAlgorithm = new VariousAlgorithm();


        [Fact]
        public void Test_PowerOfInteger()
        {
            var actual = _variousAlgorithm.PowerOfInteger(2,3);
            var expected = 8;

            Assert.Equal(expected, actual);
        }
    }
}
