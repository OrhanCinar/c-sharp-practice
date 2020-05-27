using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class StackInfixToPostfixTest
    {

        StackInfixToPostfix stackInfixToPostfix = new StackInfixToPostfix();

        [Fact]

        public void TestStackInfixToPostfix()
        {
            string exp = "a+b*(c^d-e)^(f+g*h)-i";

            var actual = stackInfixToPostfix.InfixToPostfix(exp);
            var expected = "abcd^e-fgh*+^*+i-";
            Assert.Equal(expected, actual);

        }
    }
}
