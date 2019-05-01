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

        public int GetRotationCountWithBinaryTree(int[] arr, int low, int high)
        {
            if (high < low)
            {
                return 0;
            }

            if (high == low)
            {
                return low;
            }

            int mid = low + (high - low) / 2;

            if (mid < high && arr[mid + 1] < arr[mid])
            {
                return mid + 1;
            }

            if (mid > low && arr[mid] < arr[mid - 1])
            {
                return mid;
            }

            if (arr[high] > arr[mid])
            {
                return GetRotationCountWithBinaryTree(arr, mid + 1, high);
            }

            return GetRotationCountWithBinaryTree(arr, mid + 1, high);
        }
    }
}
