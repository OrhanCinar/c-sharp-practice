using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Greedy
{
    public class FindMinNumverOfCoins
    {
        int[] deno = { 1, 2, 5, 10, 20, 50, 100, 500, 1000 };
        int n = 0;
        public FindMinNumverOfCoins()
        {
            n = deno.Length;
        }

        void FindMin(int V)
        {
            List<int> ans = new List<int>();

            for (int i = n - 1; i >= 0; i--)
            {
                while (V >= deno[i])
                {
                    V -= deno[i];
                    ans.Add(deno[i]);
                }
            }

            for (int i = 0; i < ans.Count; i++)
            {
                Console.Write(" ", ans[i]);
            }
        }
    }
}
