using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice.Dynamic_Programming
{
    public class node
    {
        public int data;
        public node left, right;
    };

    class VertexCoverProblem
    {
        int VCover(node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return 0;
            }

            int size_incl = 1 + VCover(root.left) + VCover(root.right);
            int size_excl = 0;

            if (root.left != null)
            {
                size_excl += 1 + VCover(root.right.left) + VCover(root.right.right);
            }

            return Math.Min(size_incl, size_excl);
        }
    }
}
