using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class PowerfulIntegers
    {
        public IList<int> PowerfulIntegersSln(int x, int y, int bound)
        {
            if(bound < 2) return new List<int>();

            var resultList = new List<int>();

            for (int i = 0; Math.Pow(x, i) <= bound; i++)
            {
                for (int j = 0; Math.Pow(y, j) <= bound; j++)
                {
                    var temp = Math.Pow(x, i) + Math.Pow(y, j);
                    if( temp <= bound)
                    {
                        if(!resultList.Contains((int)temp)) resultList.Add((int)temp);
                    }
                    else break;
                }
            }
            return resultList;
        }
    }
}