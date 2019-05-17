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
    }
}
