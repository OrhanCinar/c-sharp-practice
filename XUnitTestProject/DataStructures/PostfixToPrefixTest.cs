using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class PostfixToPrefixTest
    {

        StackPostfixToPrefix prefix = new StackPostfixToPrefix();

        [Fact]

        public void TestPostfixToPrefix()
        {
            string exp = "ABC/-AK/L-*";

            var actual = prefix.PostToPrefix(exp);
            var expected = "*-A/BC-/AKL";
            Assert.Equal(expected, actual);

        }
    }
}
