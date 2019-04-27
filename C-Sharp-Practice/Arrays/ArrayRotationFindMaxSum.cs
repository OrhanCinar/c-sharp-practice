using System;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationFindMaxSum
    {
        public int GetMaxSum(int[] arr)
        {
            int currentValue = 0;
            int arraySum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arraySum += arr[i];
                currentValue += i * arr[i];
            }

            int maxSum = currentValue;

            for (int i = 1; i < arr.Length; i++)
            {
                currentValue += arraySum - arr.Length * arr[arr.Length - i];

                if (currentValue > maxSum)
                {
                    maxSum = currentValue;
                }
            }

            return maxSum;
        }

        public int GetMaxSum2(int[] arr)
        {
            int result = 0;
            var length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                int curr_sum = 0;

                for (int j = 0; j < length; j++)
                {
                    int index = (i + j) % length;
                    curr_sum += j * arr[index];

                }

                result = Math.Max(result, curr_sum);
            }

            return result;
        }
    }
}
