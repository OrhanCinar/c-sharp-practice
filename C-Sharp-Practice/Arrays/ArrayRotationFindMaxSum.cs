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
    }
}
