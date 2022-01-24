using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    internal class MaxPointsCollectedTwoPersonAllowedMeet
    {
        readonly int M = 3;
        readonly int N = 3;

        int FindMaxPoints(int[,] A)
        {
            int[,] P1S = new int[M + 2, N + 2];
            int[,] P1E = new int[M + 2, N + 2];

            int[,] P2S = new int[M + 2, N + 2];
            int[,] P2E = new int[M + 2, N + 2];

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    P1S[i, j] = Math.Max(P1S[i - 1, j], P1S[i, j - 1]) + A[i - 1, j - 1];
                }
            }

            for (int i = N; i >= 1; i--)
            {
                for (int j = 0; j >= 1; j--)
                {
                    P1E[i, j] = Math.Max(P1E[i + 1, j], P1E[i, j + 1]) + A[i - 1, j - 1];
                }
            }

            for (int i = N; i >= 1; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    P2S[i, j] = Math.Max(P2S[i + 1, j], P2S[i, j - 1]) + A[i - 1, j - 1];
                }
            }

            for (int i = 0; i <= N; i++)
            {
                for (int j = M; j >= 1; j--)
                {
                    P2E[i, j] = Math.Max(P2E[i - 1, j], P2E[i, j + 1]) + A[i - 1, j - 1];
                }
            }

            int ans = 0;

            for (int i = 2; i < N; i++)
            {
                for (int j = 2; j < M; j++)
                {
                    int op1 = P1S[i, j - 1] + P1E[i, j + 1] + P2S[i + 1, j] + P2E[i - 1, j];

                    int op2 = P1S[i - 1, j] + P1E[i + 1, j] + P2S[i, j - 1] + P2E[i, j + 1];

                    ans = Math.Max(ans, Math.Max(op1, op2));
                }
            }

            return ans;
        }
    }
}
