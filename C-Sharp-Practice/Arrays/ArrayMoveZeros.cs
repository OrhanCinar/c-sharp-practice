namespace C_Sharp_Practice.Arrays
{
    public class ArrayMoveZeros
    {
        public int[] PushZerosToEnd(int[] arr, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i];
                }
            }

            while (count < n)
            {
                arr[count++] = 0;
            }

            return arr;
        }
    }
}
