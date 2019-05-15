namespace C_Sharp_Practice.Arrays
{
    public class ArrayReArrange
    {
        public int[] ReArrangeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1 && arr[i] != i) 
                {
                    int x = arr[i];

                    while (arr[x] != -1 && arr[x] != x)
                    {
                        int y = arr[x];

                        arr[x] = x;

                        x = y;
                    }

                    arr[x] = x;

                    if (arr[i] != i)
                    {
                        arr[i] = -1;
                    }
                }
            }

            return arr;
        }
    }
}
