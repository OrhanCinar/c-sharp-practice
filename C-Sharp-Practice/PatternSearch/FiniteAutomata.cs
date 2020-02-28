using System.Collections.Generic;

namespace C_Sharp_Practice.PatternSearch
{
    public class FiniteAutomata
    {
        private static int NO_OF_CHARS = 256;

        public List<int> Search(char[] pat, char[] txt)
        {
            int m = pat.Length;
            int n = txt.Length;

            List<int> patternList = new List<int>();

            int[][] tf = ReturnRectangularIntArray(m + 1, NO_OF_CHARS);

            computeTF(pat, m, tf);

            int i, state = 0;

            for (i = 0; i < n; i++)
            {
                state = tf[state][txt[i]];
                if (state == m)
                {
                    patternList.Add(i - m + 1);
                }
            }

            return patternList;
        }

        public static void computeTF(char[] pat,
                                       int M, int[][] TF)
        {
            int state, x;
            for (state = 0; state <= M; ++state)
            {
                for (x = 0; x < NO_OF_CHARS; ++x)
                {
                    TF[state][x] = getNextState(pat, M,state, x);
                }
            }
        }

        public static int getNextState(char[] pat, int M,
                                          int state, int x)
        {
            // If the character c is same as next
            // character in pattern,then simply
            // increment state
            if (state < M && (char)x == pat[state])
            {
                return state + 1;
            }

            // ns stores the result
            // which is next state
            int ns, i;

            // ns finally contains the longest
            // prefix which is also suffix in
            // "pat[0..state-1]c"

            // Start from the largest possible
            // value and stop when you find a
            // prefix which is also suffix
            for (ns = state; ns > 0; ns--)
            {
                if (pat[ns - 1] == (char)x)
                {
                    for (i = 0; i < ns - 1; i++)
                    {
                        if (pat[i] != pat[state - ns + 1 + i])
                        {
                            break;
                        }
                    }
                    if (i == ns - 1)
                    {
                        return ns;
                    }
                }
            }

            return 0;
        }

        public static int[][] ReturnRectangularIntArray(int size1,
                                                              int size2)
        {
            int[][] newArray = new int[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new int[size2];
            }

            return newArray;
        }
    }
}