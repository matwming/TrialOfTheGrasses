using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class BinaryGap
    {
        public int FindLongestBinaryGap(int N)
        {
            var list = new List<int>();
            while(N>0)
            {
                list.Add(N%2);
                N = N/2;
            }
            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] ==1)
                {
                    var dist = 0;
                    for (int j = i+1; j < list.Count; j++)
                    {
                        if (list[j]==0)
                        {
                            dist+=1;
                            max = dist> max? dist:max;
                        }
                        if (list[j] ==1)
                        {
                            dist+=1;
                            max = dist> max? dist: max;
                            break;
                        }
                    }
                }
            }
            return max;
        }
    }
}