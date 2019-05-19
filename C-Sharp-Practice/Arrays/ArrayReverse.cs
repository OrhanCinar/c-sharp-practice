namespace C_Sharp_Practice.Arrays
{
    public class ArrayReverse
    {
        public int[] ReverseArray(int[] arr, int start, int end)
        {
            int tmp;

            while (start < end)
            {
                tmp = arr[start];
                arr[start] = arr[end];
                arr[end] = tmp;
                start++;
                end--;
            }

            return arr;
        }


        public int[] ReverseArrayRecursive(int[] arr, int start, int end)
        {
            int tmp;

            if (start >= end)
                return arr;

            tmp = arr[start];
            arr[start] = arr[end];
            arr[end] = tmp;

            ReverseArrayRecursive(arr, ++start, --end);

            return arr;
        }
    }
}
