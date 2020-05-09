using C_Sharp_Practice.Searching;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject.Searching
{
    public class SublistSearchTest
    {
        SublistSearch search = new SublistSearch();

        [Fact]
        public void TestSublistSearch()
        {
            SSNode a = search.newNode(1);
            a.next = search.newNode(2);
            a.next.next = search.newNode(3);
            a.next.next.next = search.newNode(4);

            SSNode b = search.newNode(1);
            b.next = search.newNode(2);
            b.next.next = search.newNode(1);
            b.next.next.next = search.newNode(2);
            b.next.next.next.next = search.newNode(3);
            b.next.next.next.next.next = search.newNode(4);

            var actual = search.Search(a,b);
            var expected = true;
            Assert.Equal(expected, actual);
        }
    }
}
