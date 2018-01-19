using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class BinaryWatch
    {
        public IList<string> ReadBinaryWatch(int num)
        {
           
            IList<string> result = new List<string>();

            int[] hourArray = new int[] { 8, 4, 2, 1 };
            int[] minArray = new int[] { 32, 16, 8, 4, 2, 1 };
            for (int i = 0; i <= num; i++)
            {
                List<int> hourList = NumsPicker(hourArray, i);
                List<int> minList = NumsPicker(minArray, num - i);
                foreach (var hour in hourList)
                {
                    if (hour >= 12)
                    {
                        continue;
                    }
                    foreach (var min in minList)
                    {
                        if (min>=60)
                        {
                            continue;
                        }
                        string time = hour.ToString();
                        time += ":";
                        time += min < 10 ? "0" + min.ToString() : min.ToString();
                        result.Add(time);
                    }
                }
            }
            return result;
        }

        private List<int> NumsPicker(int[] digitArray, int count)
        {
            List<int> res = new List<int>();
            NumsPickerHelper(digitArray,count,0,0,res);
            return res;
        }

        private void NumsPickerHelper(int[] digitArray, int count, int position, int sum, List<int> res)
        {
            if (count == 0)
            {
                res.Add(sum);
                return;
            }
            for (int i = position; i < digitArray.Length; i++)
            {
                NumsPickerHelper(digitArray, count - 1, i + 1, sum + digitArray[i], res);
            }
        }
    }
}
