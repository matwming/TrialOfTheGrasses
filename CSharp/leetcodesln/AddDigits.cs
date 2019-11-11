using System;

namespace leetcodesln
{
    public class AddDigits
    {
        public int AddDigitsMethod(int num)
        {
            string str = Convert.ToString(num);
            int sum = 0;
            foreach (var item in str)
            {
                sum += Convert.ToInt32(item.ToString());
            }
            if (sum >= 10)
            {
                return AddDigitsMethod(sum);
            }
            return sum;
        }
    }
}
