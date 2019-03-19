using System.Collections.Generic;

namespace leetcodesln
{
    public class CountAndSay
    {
        public string CountAndSaySln(int n)
        {
            if (n == 1) return "1";

            var second = new List<int> { 1, 1 };

            return GetFinalLine(second, n - 2);
        }

        private string GetFinalLine(List<int> pre_list, int n)
        {
            if (n == 0) return string.Join("", pre_list);

            var next_list = new List<int>();

            int current = pre_list[0];
            int count = 1;

            for (int i = 1; i < pre_list.Count; i++)
            {
                if (pre_list[i] == current) count++;
                else
                {
                    next_list.Add(count);
                    next_list.Add(current);
                    current = pre_list[i];
                    count = 1;
                }
            }
            next_list.Add(count);
            next_list.Add(current);

            return GetFinalLine(next_list, --n);
        }
    }
}
