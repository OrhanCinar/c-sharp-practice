using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    class FindNUmberSolutionLinearEquation
    {
        int CountSol(int[] coeff, int start, int end, int rhs)
        {
            if (rhs == 0)
            {
                return 1;
            }

            int result = 0;


            for (int i = start; i <= end; i++)
            {
                if (coeff[i] <= rhs)
                {
                    result += CountSol(coeff, i, end, rhs - coeff[i]);
                }
            }


            return result;
        }
    }
}
