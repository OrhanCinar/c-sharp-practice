namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationBlockSwap
    {
        public int[] ArrayRoration(int[] input, int d, int n)
        {
            int i, j;
            if (d == 0 || d == n)
                return input;
            i = d;
            j = n - d;
            while (i != j)
            {
                if (i < j) /*A is shorter*/
                {
                    swap(input, d - i, d + j - i, i);
                    j -= i;
                }
                else /*B is shorter*/
                {
                    swap(input, d - i, d, j);
                    i -= j;
                }

            }
            swap(input, d - i, d, i);
            return input;
        }

        private void swap(int[] input, int fi, int si, int d)
        {
            int i, tmp;

            for (i = 0; i < d; i++)
            {
                tmp = input[fi + i];
                input[fi + i] = input[si + i];
                input[si + i] = tmp;
            }
        }
    }
}
