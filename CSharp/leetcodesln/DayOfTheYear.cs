using System;

namespace leetcodesln
{
    public class DayOfTheYear
    {
        public int DayOfYear(string date)
        {
            int[] days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int ans = 0;
            string[] words = date.Split('-');

            int year = Int32.Parse(words[0]);
            int month = Int32.Parse(words[1]);
            int day = Int32.Parse(words[2]);

            bool isLeap = false;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                isLeap = true;
            }

            if (month <= 1) return day;
            if (month == 2)
            {
                ans += 31;
                ans += day;
                return ans;
            }

            for (int i = 0; i < month - 1; i++)
            {
                ans += days[i];
            }
            ans += day;
            return isLeap ? ans + 1 : ans;
        }

    }
}
