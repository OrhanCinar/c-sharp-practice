namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationMultiplyOptimized
    {
        public bool GetArraysRotations(int[] arr)
        {
            int n = arr.Length;
            int[] tmp = new int[2 * n];

            preProcess(arr, n, tmp);

            int k = 2;
            leftRotate(arr, n, k);

            k = 3;
            leftRotate(arr, n, k);

            k = 4;
            leftRotate(arr, n, k);

            return true;
        }

        private void leftRotate(int[] arr, int n, int k)
        {

            var output = "";
            for (int i = k; i < k + n; i++)
            {
                output += arr[i % n] + " ";
            }
        }

        private void preProcess(int[] arr, int n, int[] tmp)
        {
            for (int i = 0; i < n; i++)
            {
                tmp[i] = tmp[i + n] = arr[i];
            }
        }
    }
}
