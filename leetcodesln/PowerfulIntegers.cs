using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class PowerfulIntegers
    {
        public IList<int> PowerfulIntegersSln(int x, int y, int bound)
        {
            if(bound < 2) return new List<int>();

            var hashset = new HashSet<int>();

            for (int i = 0; Math.Pow(x, i) <= bound; i++)
            {
                for (int j = 0; Math.Pow(y, j) <= bound; j++)
                {
                    var temp = Math.Pow(x, i) + Math.Pow(y, j);
                    if( temp <= bound) 
                    {
                        hashset.Add((int)temp);
                        if(y==0 || y ==1) break;
                    }
                    else break;
                }
                if(x==0 || x == 1) break;
            }
            return new List<int>(hashset);
        }
    }
}