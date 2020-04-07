using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C_Sharp_Practice.Sorting
{
	public class BucketSort
	{
		public int[] Sort(int[] arr, int n)
		{

			int minValue = arr[0];
			int maxValue = arr[0];

			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] > maxValue)
					maxValue = arr[i];
				if (arr[i] < minValue)
					minValue = arr[i];
			}

			List<int>[] bucket = new List<int>[maxValue - minValue + 1];

			for (int i = 0; i < bucket.Length; i++)
			{
				bucket[i] = new List<int>();
			}

			for (int i = 0; i < arr.Length; i++)
			{
				bucket[arr[i] - minValue].Add(arr[i]);
			}

			int k = 0;
			for (int i = 0; i < bucket.Length; i++)
			{
				if (bucket[i].Count > 0)
				{
					for (int j = 0; j < bucket[i].Count; j++)
					{
						arr[k] = bucket[i][j];
						k++;
					}
				}
			}



			return arr;
		}

	}
}
