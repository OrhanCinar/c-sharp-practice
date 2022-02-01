using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MinMaxValueOfExpression
    {
        bool IsOperator(char op)
        {
            return (op == '+' || op == '*');
        }

        void PrintMinAndMaxValueOfExp(string exp)
        {
            List<int> num = new List<int>();
            List<char> opr = new List<char>();

            string tmp = "";

            for (int i = 0; i < exp.Length; i++)
            {
                if (IsOperator(exp[i]))
                {
                    opr.Add(exp[i]);
                    num.Add(int.Parse(tmp));
                    tmp = "";
                }
                else
                {
                    tmp += exp[i];
                }
            }

            num.Add(int.Parse(tmp));

            int len = num.Count;
            int[,] minVal = new int[len, len];
            int[,] maxVal = new int[len, len];

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    minVal[i, j] = int.MaxValue;
                    maxVal[i, j] = 0;

                    if (i == j)
                    {
                        minVal[i, j] = maxVal[i, j] = num[i];
                    }
                }
            }

            for (int L = 2; L <= len; L++)
            {
                for (int i = 0; i < len - L + 1; i++)
                {
                    int j = i + L - 1;

                    for (int k = i; k < j; k++)
                    {
                        int minTmp = 0, maxTmp = 0;

                        if (opr[k] == '+')
                        {
                            minTmp = minVal[i, k] + minVal[k + 1, j];
                            maxTmp = maxVal[i, k] + minVal[k + 1, j];
                        }
                        else if (opr[k] == '*')
                        {
                            minTmp = minVal[i, k] * minVal[k + 1, j];
                            maxTmp = maxVal[i, k] * maxVal[k + 1, j];
                        }

                        if (minTmp < minVal[i, j])
                        {
                            minVal[i, j] = minTmp;
                        }

                        if (maxTmp > maxVal[i, j])
                        {
                            maxVal[i, j] = maxTmp;
                        }

                    }
                }
            }

            Console.Write("Minimum value : " + minVal[0, len - 1] + ", Maximum value : " + maxVal[0, len - 1]);

        }
    }
}
