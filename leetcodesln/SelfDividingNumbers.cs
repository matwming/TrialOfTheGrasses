using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class SelfDividingNumbers
    {
        public IList<int> SelfDividingNumbersSolution(int left, int right)
        {
            var result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if(i.ToString().Contains("0"))
                {
                    continue;
                }
                var temp = new List<int>();
                Array.ForEach(i.ToString().ToCharArray(), x=> temp.Add(int.Parse(x.ToString())));
                bool flag = true;
                foreach (var item in temp)
                {
                    if (i % item !=0)
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    result.Add(i);
                }
            }
            
            return result;
        }
    }
}
