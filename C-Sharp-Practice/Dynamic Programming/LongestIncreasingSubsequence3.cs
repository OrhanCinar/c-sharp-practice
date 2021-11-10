using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class LongestIncreasingSubsequence3
    {
        void LIS()
        {
            int[] array = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };

            List<int> list = new List<int>();
            List<int> longestList = new List<int>();
            int currenMax;
            int highestCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currenMax = int.MinValue;

                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] > currenMax)
                    {
                        list.Add(array[j]);
                        currenMax = array[j];
                    }
                }

                if (highestCount < list.Count)
                {
                    highestCount = list.Count;
                    longestList = new List<int>(list);
                }

                list.Clear();
            }

            Console.WriteLine();

            Console.WriteLine("The longest subsequence");
            foreach (int itr in longestList)
            {
                Console.Write(itr + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Length of LIS: " + highestCount);
        }
    }
}
