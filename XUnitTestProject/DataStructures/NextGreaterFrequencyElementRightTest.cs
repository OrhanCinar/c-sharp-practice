using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class NextGreaterFrequencyElementRightTest
    {
        NextGreaterFrequencyElementRight nextGreaterFrequency = new NextGreaterFrequencyElementRight();

        [Fact]
        public void TestNextGreaterFrequencyElement()
        {
            int[] a = { 3, 4, 2, 7, 5, 8, 10, 6 };
            int n = a.Length;

            int[] dp = new int[n];

            nextGreaterFrequency.Count(a, dp, n);            
            var actual = nextGreaterFrequency.GetGreater(dp, 3);
            var expected = 2;

            Assert.Equal(expected, actual);
        }
    }
}
