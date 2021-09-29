using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class Lissnode
    {
        public int data, liss;
        public Lissnode left, right;

        public Lissnode(int data)
        {
            this.data = data;
            this.liss = 0;
        }
    }
    class LargestIndependentSetProblem2
    {
        int Liss(Lissnode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.liss != 0)
            {
                return root.liss;
            }

            if (root.left == null && root.right == null)
            {
                return root.liss = 1;
            }

            int liss_excl = Liss(root.left) + Liss(root.right);


            int liss_incl = 1;

            if (root.left != null)
            {
                liss_incl += Liss(root.left.left) + Liss(root.left.right);
            }

            if (root.right != null)
            {
                liss_excl += Liss(root.right.left) + Liss(root.right.right);
            }

            return root.liss = Math.Max(liss_excl, liss_incl);
        }
    }
}
