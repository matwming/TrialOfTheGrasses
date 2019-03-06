using System.Collections.Generic;

namespace leetcodesln
{
    public class AddToArray_FormOfInteger
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var result = new int[256];
            for (int i = A.Length - 1, j = 255; i >= 0; i--, j--)
            {
                result[j] = A[i];
            }

            bool r = false;

            var ptr = result.Length - 1;
            while (K != 0)
            {
                if (r) result[ptr] += 1;
                var res = result[ptr] + K % 10;
                r = res > 9;
                result[ptr] = res > 9 ? res - 10 : res;
                ptr--;
                K /= 10;
            }

            while (r)
            {
                var temp = result[ptr] + 1;
                r = temp > 9;
                result[ptr--] = temp > 9 ? temp - 10 : temp;
            }

            bool flag = false;
            var list = new List<int>();
            for (int i = 0; i < result.Length; i++)
            {
                if (!flag)
                {
                    if (result[i] != 0)
                    {
                        list.Add(result[i]);
                        flag = true;
                    }
                }
                else
                {
                    list.Add(result[i]);
                }
            }

            if (list.Count == 0) return new int[] { 0 };
            return list;
        }
    }
}