namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationCount
    {
        public int GetRotationCount(int[] arr)
        {
            int min = arr[0];
            int minIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
