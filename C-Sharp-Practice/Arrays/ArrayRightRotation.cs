namespace C_Sharp_Practice.Arrays
{
    public class ArrayRightRotation
    {
        public int[] RightRotate(int[] arr, int d, int n)
        {
            ReverseArray(arr, 0, n - 1);
            ReverseArray(arr, 0, d - 1);
            ReverseArray(arr, d, n - 1);
            return arr;
        }

        private void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int tmp = arr[start];
                arr[start] = arr[end];
                arr[end] = tmp;
                start++;
                end--;
            }
        }
    }
}
