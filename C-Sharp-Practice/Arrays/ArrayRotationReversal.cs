namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationReversal
    {
        public int[] ReverseArray(int[] input, int d, int n)
        {
            Reverse(input, 0, d - 1);
            Reverse(input, d, n - 1);
            Reverse(input, 0, n - 1);

            return input;
        }

        private void Reverse(int[] input, int start, int end)
        {
            int tmp;

            while (start < end)
            {
                tmp = input[start];
                input[start] = input[end];
                input[end] = tmp;
                start++;
                end--;
            }
        }
    }
}
