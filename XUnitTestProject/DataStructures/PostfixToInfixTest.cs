using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class PostfixToInfixTest
    {
        StackPostfixToInfix stackPostfixToInfix = new StackPostfixToInfix();

        [Fact]
        public void TestPostfixToInfix()
        {
            string exp = "ab*c+";

            var actual = stackPostfixToInfix.PostfixToınfix(exp);
            var expected = "((a*b)+c)";
            Assert.Equal(expected, actual);
        }
    }
}
