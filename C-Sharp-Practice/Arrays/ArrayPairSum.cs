namespace C_Sharp_Practice.Arrays
{
    public class ArrayPairSum
    {
        public bool CheckArrayPairSum(int[] arr, int sum)
        {
            int i;
            for (i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    break;
                }
            }

            int l = (i + 1) % arr.Length;

            int r = 1;

            while (l != r)
            {
                if (arr[l] + arr[r] == sum)
                {
                    return true;
                }

                if (arr[l] + arr[r] < sum)
                {
                    l = (l + 1) % arr.Length;
                }
                else
                {
                    r = (arr.Length + r - 1) % arr.Length;
                }
            }
            return false;
        }
    }
}
