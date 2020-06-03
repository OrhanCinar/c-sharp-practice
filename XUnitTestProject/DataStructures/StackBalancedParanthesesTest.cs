using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class StackBalancedParanthesesTest
    {
        StackBalancedParantheses stackBalancedParantheses = new StackBalancedParantheses();

        [Fact]
        public void TestStackBalancedParantheses()
        {
            char[] exp = { '{', '(', ')', '}', '[', ']' };
            var actual = stackBalancedParantheses.AreparanthesisBalances(exp);
            var expected = true;
            Assert.Equal(expected, actual);
        }
    }
}
