using C_Sharp_Practice.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static C_Sharp_Practice.Sorting.QuickSortSingleLinkedList;

namespace XUnitTestProject.Sorting
{
    public class QuickSortDoubleLinkedListTest
    {
        QuickSortDoubleLinkedList sort = new QuickSortDoubleLinkedList();

        [Fact]
        public void TestQuickSortDoubleLinkedList()
        {
            sort.Push(30);
            sort.Push(3);
            sort.Push(4);
            sort.Push(20);
            sort.Push(5);
            
            sort.Sort(sort.head);
            var testArray = new int[] { 3, 4, 5, 20, 30 };

            int counter = 0;
            bool isSorted = true;

         
            while (sort.head.next != null)
            {
                if (testArray[counter++] != sort.head.data)
                {
                    isSorted = false;
                }

                sort.head = sort.head.next;   
            }

            Assert.True(isSorted);
        }
    }
}
