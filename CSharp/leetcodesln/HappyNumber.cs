using System;
using System.Collections.Generic;
using System.Globalization;

namespace leetcodesln
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            var arr = new List<double>();
            return IsHappyAux(arr, n);
        }

        private bool IsHappyAux(List<double> arr, double n)
        {
            if (n == 1) return true;

            var strnum = n.ToString("G", CultureInfo.CreateSpecificCulture("en-US"));

            double sum = 0;
            for (int i = 0; i < strnum.Length; i++)
            {
                double foo = strnum[i] - '0';
                sum += Math.Pow(foo, 2);
            }
            if (arr.Contains(sum)) return false;
            arr.Add(sum);

            return IsHappyAux(arr, sum);
        }
    }
}
