using System;
using System.Collections.Generic;
using System.Text;
using C_Sharp_Practice.DataStructures;
using Xunit;

namespace XUnitTestProject.DataStructures
{
    public class IterativeTowerOfHanoiTest
    {
        IterativeTowerOfHanoi iterativeTowerOfHanoi = new IterativeTowerOfHanoi();

        [Fact]
        public void Test_IterativeTowerOfHanoi()
        {
            int num_of_disks = 3;

            Stack src, dest, aux;

            src = iterativeTowerOfHanoi.CreateStack(num_of_disks);
            dest = iterativeTowerOfHanoi.CreateStack(num_of_disks);
            aux = iterativeTowerOfHanoi.CreateStack(num_of_disks);

            iterativeTowerOfHanoi.TohIterative(num_of_disks, src, aux, dest);
        }
    }
}
