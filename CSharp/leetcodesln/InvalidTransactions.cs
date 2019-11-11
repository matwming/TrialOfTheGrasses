using System;
using System.Collections.Generic;

namespace leetcodesln
{
    public class InvalidTransactions
    {
        public IList<string> InvalidTranscationsSln(string[] transactions)
        {
            var ans = new List<string>();

            for (int i = 0; i < transactions.Length; i++)
            {
                bool isValid = Validate(transactions, i);
                if (!isValid)
                {
                    ans.Add(transactions[i]);
                }
            }
            return ans;
        }

        private bool Validate(string[] transactions, int pos)
        {
            string[] elements = transactions[pos].Split(",");
            var name = elements[0];
            var time = int.Parse(elements[1]);
            var amount = int.Parse(elements[2]);
            var city = elements[3];

            if (amount > 1000) return false;
            for (int i = 0; i < transactions.Length; i++)
            {
                if (i == pos) continue;

                string[] ele = transactions[i].Split(",");
                var name1 = ele[0];
                var time1 = int.Parse(ele[1]);
                var amount1 = int.Parse(ele[2]);
                var city1 = ele[3];

                if (name == name1 && city != city1 && Math.Abs(time1 - time) <= 60) return false;
            }
            return true;
        }
    }
}
