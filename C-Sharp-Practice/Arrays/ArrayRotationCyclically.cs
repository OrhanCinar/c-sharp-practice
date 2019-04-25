namespace C_Sharp_Practice.Arrays
{
    public class ArrayRotationCyclically
    {
        public int[] RotateArray(int[] input)
        {
            int tmp = input[input.Length - 1];
            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = tmp;
            return input;
        }
    }
}
