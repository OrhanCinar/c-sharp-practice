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

        public int[] PushZerosToEnd2(int[] arr, int n)
        {
            int count = 0;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    tmp = arr[count];
                    arr[count] = arr[i];
                    arr[i] = tmp;
                    count++;
                }
            }

            return arr;
        }
    }
}
