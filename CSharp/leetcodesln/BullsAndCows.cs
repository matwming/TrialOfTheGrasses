using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class BullsAndCows
    {
        public string GetHint(string secret, string guess)
        {
            int c = 0;
            var bulls = new HashSet<int>();
            var remains = new Dictionary<char, int>();
            for (int i = 0; i < secret.Length; ++i)
            {
                if (secret[i] == guess[i]) bulls.Add(i);
                else
                {
                    if (remains.ContainsKey(secret[i])) remains[secret[i]]++;
                    else remains.Add(secret[i], 1);
                }
            }

            for (int i = 0; i < guess.Length; ++i)
            {
                if (bulls.Contains(i)) continue;
                if (remains.ContainsKey(guess[i]))
                {
                    c++;
                    remains[guess[i]]--;
                    if (remains[guess[i]] == 0) remains.Remove(guess[i]);
                }
            }
            var ans = new StringBuilder();
            ans.Append(bulls.Count).Append("A").Append(c).Append("B");
            return ans.ToString();
        }

        // one pass
        public string GetHintOptimal(string secret, string guess)
        {
            int bulls = 0, cows = 0;
            int[] numbers = new int[10];
            for (int i = 0; i < guess.Length; ++i)
            {
                if (secret[i] == guess[i]) bulls++;
                else
                {
                    if (numbers[secret[i] - '0'] < 0) cows++;
                    if (numbers[guess[i] - '0'] > 0) cows++;
                    numbers[secret[i] - '0']++;
                    numbers[guess[i] - '0']--;
                }
            }
            return bulls + "A" + cows + "B";
        }
    }
}
