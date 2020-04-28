using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static C_Sharp_Practice.Sorting.QuickSortSingleLinkedList;

namespace XUnitTestProject.Sorting
{
    public class QuickSortSingleLinkedListTest
    {
        QuickSortSingleLinkedList sort = new QuickSortSingleLinkedList();

        [Fact]
        public void TestQuickSortSingleLinkedList()
        {
            sort.addNode(30);
            sort.addNode(3);
            sort.addNode(4);
            sort.addNode(20);
            sort.addNode(5);
            var n = sort.head;
            while (n.next != null)
            {
                n = n.next;
            }

            var actual = sort.Sort(sort.head, n);
            var testArray = new int[] { 3, 4, 5, 20, 30 };

            int counter = 0;
            bool isSorted = true;

            n = sort.head;
            while (n.next != null)
            {
                if (testArray[counter++] != n.data)
                {
                    isSorted = false;
                }

                n = n.next;   
            }

            Assert.True(isSorted);
        }
    }
}
