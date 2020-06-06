using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class NextGreaterFrequencyElementTest
    {
        NextGreaterFrequencyElement nextGreaterFrequency = new NextGreaterFrequencyElement();

        [Fact]
        public void TestNextGreaterFrequencyElement()
        {
            int[] a = { 1, 1, 2, 3, 4, 2, 1 };
            int len = 7;
            int max = int.MinValue;
            for (int i = 0; i < len; i++)
            {
                // Getting the max element of the array 
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            int[] freq = new int[max + 1];

            for (int i = 0; i < max + 1; i++)
                freq[i] = 0;

            // Calculating frequency of each element 
            for (int i = 0; i < len; i++)
            {
                freq[a[i]]++;
            }
            var actual = nextGreaterFrequency.FindNextGreaterFrequency(a, len, freq);
            var expected = "-1,-1,1,2,2,1,-1,";

            Assert.Equal(expected, actual);
        }
    }
}
