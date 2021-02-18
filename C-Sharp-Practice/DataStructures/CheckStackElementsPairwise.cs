using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Practice.DataStructures
{
    public class CheckStackElementsPairwise
    {
        public bool PairWiseConsecutive(Stack<int> s)
        {

            Stack<int> aux = new Stack<int>();

            while(s.Count != 0)
            {
                aux.Push(s.Peek());
                s.Pop();
            }


            bool result = true;

            while(aux.Count > 1)
            {
                int x = aux.Peek();
                aux.Pop();
                int y = aux.Peek();
                aux.Pop();

                if(Math.Abs(x-y) != 1)
                {
                    result = false;
                }

                s.Push(x);
                s.Push(y);
            }

            if (aux.Count == 1)
            {
                s.Push(aux.Peek());
            }

            return result;
        }
    }
}
