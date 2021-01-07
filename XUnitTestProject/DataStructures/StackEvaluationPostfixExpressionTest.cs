using System;
using System.Collections.Generic;
using System.Text;
using C_Sharp_Practice.DataStructures;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class StackEvaluationPostfixExpressionTest
    {
        StackEvaluationPostfixExpression stackEvaluationPostfixExpression = new StackEvaluationPostfixExpression();

        [Fact]
        public void Test_StackEvaluationPostfixExpression()
        {
            var exp = ("231*+9-");
            var actual = stackEvaluationPostfixExpression.Expresion(exp);
            var expected = "-4";
            Assert.Equal(expected, actual);
        }
    }
}
