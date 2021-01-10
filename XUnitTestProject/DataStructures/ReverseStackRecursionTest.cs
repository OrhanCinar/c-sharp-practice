using System;
using System.Collections.Generic;
using System.Text;
using C_Sharp_Practice.DataStructures;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class ReverseStackRecursionTest
    {

        ReverseStackRecursion reverseStackRecursion = new ReverseStackRecursion();

        [Fact]
        public void Test_ReverseStackRecursion()
        {

            reverseStackRecursion.Push('1');
            reverseStackRecursion.Push('2');
            reverseStackRecursion.Push('3');
            reverseStackRecursion.Push('4');

            reverseStackRecursion.ReverseStack();
            var stack = reverseStackRecursion.GetStack();
        }
    }
}
