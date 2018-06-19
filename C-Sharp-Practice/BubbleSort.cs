namespace C_Sharp_Practice
{
    public class BubbleSort
    {
        public int[] SortDesc(int[] elements)
        {
            int temp;
            bool flag = true;

            for (int i = 0; i < elements.Length && flag; i++)
            {
                flag = false;
                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j + 1] > elements[j])
                    {
                        temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return elements;
        }

        public int[] SortAsc(int[] elements)
        {
            int temp;
            bool flag = true;

            for (int i = 0; i < elements.Length && flag; i++)
            {
                flag = false;
                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j + 1] < elements[j])
                    {
                        temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return elements;
        }
    }
}
