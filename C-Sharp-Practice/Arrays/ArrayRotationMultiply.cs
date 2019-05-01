using System;

namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationMultiply
    {
        public bool GetArraysRotations(int[] arr)
        {
            int n = arr.Length;
            int[] tmp = new int[2 * n];

            preProcess(arr, n, tmp);

            int k = 2;
            leftRotate(arr, n, k, tmp);

            k = 3;
            leftRotate(arr, n, k, tmp);

            k = 4;
            leftRotate(arr, n, k, tmp);

            return true;
        }

        private void leftRotate(int[] arr,int n, int k, int[] tmp)
        {
            int start = k % n;
            var output = "";
            for (int i = start; i < start+n; i++)
            {
                output += tmp[i] + " ";                
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
