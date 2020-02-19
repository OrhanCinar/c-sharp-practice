using C_Sharp_Practice.PatternSearch;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.PatternSearch
{
    public class RabinKarpAlgorithmTest
    {
        RabinKarpAlgorithm rabinKarp = new RabinKarpAlgorithm();

        [Fact]
        public void TestRabinKarpAlgorithm()
        {
            string text = "GEEKS FOR GEEKS";
            string pat = "GEEK";
            int q = 101;

            var actual = rabinKarp.Search(pat,text,q);
            //rabinKarp.search(pat,text, q);

            Assert.Equal(2, actual.Count);
        }

    }
}
