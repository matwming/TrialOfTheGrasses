using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class GrumpyBookstoreOwner
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int X)
        {
            
            int original = 0;
            for (int i = 0; i < customers.Length; i++)
            {
                original += grumpy[i] == 1 ? 0 : customers[i];
            }
            int maxSatisfied = original;
            for (int i = 0; i <= customers.Length -X; i++)
            {
                var current = original;
                for (int j = 0; j < X; j++)
                {
                    if (grumpy[i + j] != 0) current += customers[i + j]; 
                }
                maxSatisfied = maxSatisfied > current ? maxSatisfied : current;
            }
            return maxSatisfied;
        }
    }
}
