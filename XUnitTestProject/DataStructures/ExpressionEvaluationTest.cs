using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{


    public class ExpressionEvaluationTest
    {
        ExpressionEvaluation expressionEvaluation = new ExpressionEvaluation();

        [Fact]
        public void Test_ExpressionEvaluation()
        {
            var evaluate1 = "10 + 2 * 6";
            var evaluate2 = "100 * 2 + 12";
            var evaluate3 = "100 * (2 + 12)";
            var evaluate4 = "100 * ( 2 + 12 ) / 14";


            var actual = expressionEvaluation.Evaluate(evaluate1);
            var expected = 22;
            Assert.Equal(expected, actual);


            actual = expressionEvaluation.Evaluate(evaluate2);
            expected = 212;
            Assert.Equal(expected, actual);

            actual = expressionEvaluation.Evaluate(evaluate3);
            expected = 1400;
            Assert.Equal(expected, actual);

            //actual = expressionEvaluation.Evaluate(evaluate4);
            //expected = 100;
            //Assert.Equal(expected, actual);

        }
    }
}


