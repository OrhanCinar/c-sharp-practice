using C_Sharp_Practice.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class StockSpanProblemTest
    {
        StockSpanProblem stockSpanProblem = new StockSpanProblem();

        [Fact]
        public void TestStockSpanProblem()
        {
            int[] price = { 10, 4, 5, 90, 120, 80 };
            int n = price.Length;
            int[] s = new int[n];
            stockSpanProblem.CalculateSpan(price, n, s);
            int[] expected = { 1, 1, 2, 4, 5, 1 };

            Assert.Equal(expected, s);
        }
    }
}
