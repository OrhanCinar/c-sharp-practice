using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class FormMinNumberFromSequence
    {
        public void PrintMinNumberFroPattern(string arr)
        {
            int curr_max = 0;

            int last_entry = 0;
            int j;

            for (int i = 0; i < arr.Length; i++)
            {
                int noOfNextD = 0;


                switch (arr[i])
                {
                    case 'I':
                        {
                            j = i + 1;
                            while (j < arr.Length && arr[j] == 'D')
                            {
                                noOfNextD++;
                                j++;
                            }

                            if (i == 0)
                            {
                                curr_max = noOfNextD + 2;

                                Console.Write(" " + ++last_entry);
                                Console.Write(" " + curr_max);

                                last_entry = curr_max;
                            }
                            else
                            {
                                curr_max = curr_max + noOfNextD + 1;
                                last_entry = curr_max;
                                Console.Write(" " + last_entry);
                            }

                            for (int k = 0; k < noOfNextD; k++)
                            {
                                Console.Write("" + --last_entry);
                            }

                            break;
                        }

                    case 'D':
                        if (i == 0)
                        {
                            j = i + 1;

                            while (j < arr.Length && arr[j] == 'D')
                            {
                                noOfNextD++;
                                j++;
                            }

                            curr_max = noOfNextD + 2;
                            Console.Write(" " + curr_max + " " + (curr_max - 1));
                            last_entry = curr_max - 1;
                        }
                        else
                        {
                            Console.Write(" " + (last_entry - 1));
                            last_entry--;
                        }
                        break;
                }
            }
        }
    }
}
