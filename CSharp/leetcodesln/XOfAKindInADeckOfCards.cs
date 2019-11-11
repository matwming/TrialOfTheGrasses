using System.Collections.Generic;

namespace leetcodesln
{
    public class XOfAKindInADeckOfCards
    {
        public bool HasGroupSizeX(int[] deck)
        {

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < deck.Length; i++)
            {
                if (dict.ContainsKey(deck[i])) dict[deck[i]]++;
                else dict.Add(deck[i], 1);
            }

            var gcd = 0;

            foreach (var item in dict)
            {
                gcd = GetGreatestCommonDivisor(item.Value, gcd);
            }
            return deck.Length > 1 && gcd > 1;
        }

        private int GetGreatestCommonDivisor(int a, int b)
        {
            return b > 0 ? GetGreatestCommonDivisor(b, a % b) : a;
        }
    }
}
