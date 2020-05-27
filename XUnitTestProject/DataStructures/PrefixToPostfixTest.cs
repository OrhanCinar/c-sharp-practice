using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class PrefixToPostfixTest
    {

        PrefixToPostfix prefix = new PrefixToPostfix();

        [Fact]

        public void TestPrefixToPostfix()
        {
            string exp = "*-A/BC-/AKL";

            var actual = prefix.PreToPost(exp);
            var expected = "ABC/-AK/L-*";
            Assert.Equal(expected, actual);

        }
    }
}
