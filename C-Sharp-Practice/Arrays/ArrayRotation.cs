namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotation
    {
        public int[] ArrayRoration1(int[] input, int d, int n)
        {
            int[] tmpArray = new int[d];
            for (int i = 0; i < d; i++)
            {
                tmpArray[i] = input[i];
            }

            for (int i = d; i < n; i++)
            {
                input[i-d] = input[i];
            }

            for (int i = 0; i < d; i++)
            {
                input[n - d + i] = tmpArray[i];
            }

            return input;
        }
    }
}
